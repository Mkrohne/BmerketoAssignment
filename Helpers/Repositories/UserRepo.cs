using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Repositories
{
    public class UserRepo : Repo<UserEntity>
    {
        public UserRepo(DataContext context) : base(context) 
        {
        
        }
    }
}
