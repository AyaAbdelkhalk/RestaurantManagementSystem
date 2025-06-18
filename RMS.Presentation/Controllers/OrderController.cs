using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.Order;

namespace RMS.Presentation.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderServices _orderServices;
        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
