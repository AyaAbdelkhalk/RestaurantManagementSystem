using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.ReservationService;

namespace RMS.Presentation.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationServices _reservationServices;
        public ReservationController(IReservationServices reservationServices)
        {
            _reservationServices = reservationServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
