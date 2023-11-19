using WebApp.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.ViewModels;

public class RegisterViewModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;


    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } = null!;
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string? Company { get; set; }


    public static implicit operator UserEntity(RegisterViewModel model)
    {
        return new UserEntity
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            UserName = model.Email,
            PhoneNumber = model.PhoneNumber,
            Company = model.Company
        };
    }

    public static implicit operator AddressEntity(RegisterViewModel model)
    {
        return new AddressEntity
        {
            StreetName = model.StreetName,
            PostalCode = model.PostalCode,
            City = model.City
        };
    }
}
