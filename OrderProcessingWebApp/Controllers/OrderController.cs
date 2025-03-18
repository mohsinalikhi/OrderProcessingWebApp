using Microsoft.AspNetCore.Mvc;
using OrderProcessingWebApp.Models;

namespace OrderProcessingWebApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessOrder(OrderModel model)
        {
            if (model.OrderAmount >= 100 && model.CustomerType == "Loyal")
            {
                model.Discount = model.OrderAmount * 0.10m;
            }
            else
            {
                model.Discount = 0;
            }

            model.FinalTotal = model.OrderAmount - model.Discount;

            return View("OrderResult", model);
        }

    }
}
