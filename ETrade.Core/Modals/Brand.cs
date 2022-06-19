
namespace ETrade.Core.Modals
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}