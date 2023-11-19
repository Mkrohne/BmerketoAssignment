using WebApp.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Repositories;

public class ProductCategoryRepo : Repo<ProductCategoryEntity>
{
    public ProductCategoryRepo(DataContext context) : base(context) 
    {

    }
}
