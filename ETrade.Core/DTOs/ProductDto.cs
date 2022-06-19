
namespace ETrade.Core.DTOs
{
    public class ProductDto : IDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public DateTime ModelYear { get; set; }
        public decimal Discount { get; set; }
    }
}