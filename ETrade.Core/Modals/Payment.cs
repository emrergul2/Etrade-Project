namespace ETrade.Core.Modals
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public Order Order { get; set; }
    }
}
