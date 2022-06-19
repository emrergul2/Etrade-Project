namespace ETrade.Core.Modals
{
    public class Comment: IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerComment { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}