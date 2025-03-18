namespace OrderProcessingApp.Services
{
    public class OrderService
    {
        public decimal CalculateDiscount(decimal orderAmount, string customerType)
        {
            if (orderAmount >= 100 && customerType == "Loyal")
            {
                return orderAmount * 0.10m;
            }
            return 0;
        }
    }
}
