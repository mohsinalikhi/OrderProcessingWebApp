namespace OrderProcessingWebApp.Models
{
    public class OrderModel
    {
        public decimal OrderAmount { get; set; }
        public string CustomerType { get; set; } = "New"; // Default value
        public decimal Discount { get; set; }
        public decimal FinalTotal { get; set; }
    }
}
