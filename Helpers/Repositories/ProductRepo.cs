using WebApp.Contexts;
using WebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace WebApp.Helpers.Repositories
{
    public class ProductRepo : Repo<ProductEntity>
    {

        private readonly DataContext _context;
        public ProductRepo(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<ProductEntity>> GetAsync()
        {
            var products = await _context.Product.Include(x => x.ProductCategories).ThenInclude(x => x.Category).ToListAsync();
            return products;
        }

        public override async Task<ProductEntity> GetAsync(Expression<Func<ProductEntity, bool>> expression)
        {
            var product = await _context.Product.Include(x => x.ProductCategories).ThenInclude(x => x.Category).FirstOrDefaultAsync(expression);
            return product!;
        }


    }
}
