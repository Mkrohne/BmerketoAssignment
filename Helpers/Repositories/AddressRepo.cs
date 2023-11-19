using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Repositories;

public class AddressRepo : Repo<AddressEntity>
{
    public AddressRepo(DataContext context) : base(context) 
    {
        
    }
}
