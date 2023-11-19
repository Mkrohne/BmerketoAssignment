using WebApp.Helpers.Repositories;
using WebApp.Models.Entities;
using System.Diagnostics;

namespace WebApp.Helpers.Services;

public class AddressService
{
    private readonly AddressRepo _addressRepo;
    private readonly UserAddressRepo _userAddressRepo;

    public AddressService(AddressRepo addressRepo, UserAddressRepo userAddressRepo)
    {
        _addressRepo = addressRepo;
        _userAddressRepo = userAddressRepo;
    }

    public async Task<AddressEntity> GetOrCreateAsync(AddressEntity entity)
    {
        var _entity = await _addressRepo.GetAsync(x => x.StreetName == entity.StreetName && x.PostalCode == entity.PostalCode && x.City == entity.City);
        _entity ??= await _addressRepo.AddAsync(entity);

        return _entity;
    }


    public async Task<bool> AddUserAddress(string userId, int addressId)
    {
        try
        {
            var entity = await _userAddressRepo.AddAsync(new UserAddressEntity
            {
                UserId = userId,
                AddressId = addressId
            });

            if (entity != null)
                return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
}
