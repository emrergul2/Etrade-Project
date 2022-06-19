namespace ETrade.Core.Modals
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public DateTime ModelYear { get; set; }
        public decimal Discount { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public IEnumerable<OrderProduct> OrderProducts { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
