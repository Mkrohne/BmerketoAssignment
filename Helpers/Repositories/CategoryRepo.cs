using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Repositories;

public class CategoryRepo : Repo<CategoryEntity>
{
    public CategoryRepo(DataContext context) : base(context)
    {

    }
}
