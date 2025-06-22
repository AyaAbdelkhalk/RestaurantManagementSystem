using Mapster;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.CouponService;
using RMS.Application.ViewModels.CouponViewModel;

namespace RMS.Presentation.Controllers
{
    public class CouponController : Controller
    {
        private readonly ICouponServices _couponServices;
        public CouponController(ICouponServices couponServices)
        {
            _couponServices = couponServices;
        }
        public async Task<IActionResult> Index()
        {
            var coupons = await _couponServices.GetAllCouponsAsync();
            return View(coupons);
        }
        public async Task<IActionResult> Details(int id)
        {
            var coupon = await _couponServices.GetCouponByIdAsync(id);
            if (coupon == null) return NotFound();
            return View(coupon);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddCouponVM coupon)
        {
            if (!ModelState.IsValid) return View(coupon);
            await _couponServices.CreateCouponAsync(coupon);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var coupon = await _couponServices.GetCouponByIdAsync(id);
            if (coupon == null) return NotFound();
            var model= coupon.Adapt<UpdateCouponVM>();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateCouponVM coupon)
        {
            if (id != coupon.CouponId) return BadRequest();
            if (!ModelState.IsValid) return View(coupon);
            var updatedCoupon = await _couponServices.UpdateCouponAsync(id, coupon);
            if (updatedCoupon == null) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var coupon = await _couponServices.GetCouponByIdAsync(id);
            if (coupon == null) return NotFound();
            return RedirectToAction(nameof(Index));
        }

    }
}
