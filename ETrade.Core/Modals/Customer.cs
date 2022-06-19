
namespace ETrade.Core.Modals
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Address { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}