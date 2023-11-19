using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Repositories
{
    public class UserAddressRepo : Repo<UserAddressEntity>
    {
        public UserAddressRepo(DataContext context) : base(context) 
        {
        
        }
    }
}
