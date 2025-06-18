using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.Coupon;

namespace RMS.Presentation.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponServices _couponServices;
        public CouponController(ICouponServices couponServices)
        {
            _couponServices = couponServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
