using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Repositories
{
    public class ContactFormRepo : Repo<ContactFormEntity>
    {
        public ContactFormRepo(DataContext context) : base(context) 
        {
            
        }
    }
}
