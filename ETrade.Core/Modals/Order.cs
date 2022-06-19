namespace ETrade.Core.Modals
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<OrderProduct> OrderProducts { get; set; }
        public Payment Payment { get; set; }
    }
}