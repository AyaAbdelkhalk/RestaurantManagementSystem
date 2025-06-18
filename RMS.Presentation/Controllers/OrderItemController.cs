using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.OrderItem;

namespace RMS.Presentation.Controllers
{
    public class OrderItemController : Controller
    {
        private readonly IOrderItemServices _orderItemServices;
        public OrderItemController(IOrderItemServices orderItemServices)
        {
            _orderItemServices = orderItemServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
