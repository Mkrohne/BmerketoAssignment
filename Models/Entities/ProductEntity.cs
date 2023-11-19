namespace WebApp.Models.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Price { get; set; } = null!;
        public string LinkUrl { get; set; } = null!;
        public ICollection<ProductCategoryEntity> ProductCategories { get; set; } = new HashSet<ProductCategoryEntity>();

    }
}
