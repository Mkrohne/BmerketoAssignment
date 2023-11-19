using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;

namespace WebApp.Contexts
{
    public class DataContext : IdentityDbContext<UserEntity>
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AddressEntity> Address { get; set; }
        public DbSet<UserAddressEntity> UserAddress { get; set; }
        public DbSet<ProductEntity> Product { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
        public DbSet<ContactFormEntity> ContactForm { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { Id = 1, CategoryName = "new"},
                new CategoryEntity { Id = 2, CategoryName = "Featured"},
                new CategoryEntity { Id = 3, CategoryName = "popular"}
                );

            builder.Entity<ProductEntity>().HasData(
                new ProductEntity { Id = 1, Title = "Apple watch series", Price = "$30", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 2, Title = "Table lamp", Price = "$10", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 3, Title = "Laptop thinkpad lenovo", Price = "$400", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 4, Title = "Table lamp", Price = "$10", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 5, Title = "Gumshoe black fashion", Price = "$12", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 6, Title = "Woman white dress", Price = "$13", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 7, Title = "Kettle water boilder", Price = "$10", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 8, Title = "Congee cooker rice cooker", Price = "$11", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 9, Title = "Pizza tomato sauce kebab", Price = "$5", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 10, Title = "Samsung S23 ultra", Price = "$220", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 11, Title = "White pillow", Price = "$14", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 12, Title = "Brown summer jacket", Price = "$190", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 13, Title = "Mosepad black", Price = "$3", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 14, Title = "Round mirror", Price = "$10", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 15, Title = "RGB keyboard", Price = "$10", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 16, Title = "USB hub", Price = "$8", LinkUrl = "/images/placeholders/270x295.svg" },
                new ProductEntity { Id = 17, Title = "Coffie mug black", Price = "$3", LinkUrl = "/images/placeholders/369x295.svg" },
                new ProductEntity { Id = 18, Title = "Fast charger iPhone", Price = "$30", LinkUrl = "/images/placeholders/369x295.svg" },
                new ProductEntity { Id = 19, Title = "Powerbank 10000mah", Price = "$60", LinkUrl = "/images/placeholders/369x295.svg" }
                );
            builder.Entity<ProductCategoryEntity>().HasData(
                new ProductCategoryEntity { ProductId = 1, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 2, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 3, CategoryId = 3 },
                new ProductCategoryEntity { ProductId = 4, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 5, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 6, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 7, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 8, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 9, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 10, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 11, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 12, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 13, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 14, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 15, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 16, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 17, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 18, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 19, CategoryId = 2 }
                );

        }

    }
    
}
