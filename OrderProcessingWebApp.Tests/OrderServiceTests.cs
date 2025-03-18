using OrderProcessingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingWebApp.Tests
{
    public class OrderServiceTests
    {
        private readonly OrderService _orderService;

        public OrderServiceTests()
        {
            _orderService = new OrderService();
        }

        [Fact]
        public void CalculateDiscount_LoyalCustomerWith100Dollars_ShouldReturn10PercentDiscount()
        {
            // Arrange
            decimal orderAmount = 100;
            string customerType = "Loyal";

            // Act
            decimal discount = _orderService.CalculateDiscount(orderAmount, customerType);

            // Assert
            Assert.Equal(10, discount);
        }

        [Fact]
        public void CalculateDiscount_NewCustomerWith100Dollars_ShouldReturnNoDiscount()
        {
            // Arrange
            decimal orderAmount = 100;
            string customerType = "New";

            // Act
            decimal discount = _orderService.CalculateDiscount(orderAmount, customerType);

            // Assert
            Assert.Equal(0, discount);
        }
    }
}
