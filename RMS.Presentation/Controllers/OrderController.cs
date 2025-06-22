using Mapster;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.CouponService;
using RMS.Application.Services.OrderService;
using RMS.Application.ViewModels.CouponViewModel;
using RMS.Application.ViewModels.OrderViewModel;
using RMS.Core.Enum;
using RMS.Core.Models;

namespace RMS.Presentation.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderServices _orderServices;
        private readonly ICouponServices _couponServices;
        public OrderController(IOrderServices orderServices , ICouponServices couponServices)
        {
            _orderServices = orderServices;
            _couponServices = couponServices;
        }
        public async Task<IActionResult> Index()
        {
            var orders = await _orderServices.GetAllAsync();
            return View(orders);
        }

        public async Task<IActionResult> Details(int id)
        {
            var order = await _orderServices.GetByIdAsync(id);
            if (order == null) return NotFound();
            if (order.CouponId.HasValue && order.CouponId.Value > 0)
            {
                var coupon = await _couponServices.GetCouponByIdAsync(order.CouponId.Value);
                if (coupon != null)
                {
                    order.CouponCode = coupon.CouponCode;
                }
            }
            else
            {
                order.CouponCode = "No Coupon";
            }
            return View(order);
        }

        public async Task<IActionResult> Create()
        {
            // view bag
            ViewBag.OrderTypes = Enum.GetValues(typeof(RMS.Core.Enum.OrderType)).Cast<RMS.Core.Enum.OrderType>().ToList();
            ViewBag.OrderStatuses = Enum.GetValues(typeof(RMS.Core.Enum.OrderStatus)).Cast<RMS.Core.Enum.OrderStatus>().ToList();
            ViewBag.Tables = new List<int> { 1, 2, 3, 4, 5 }; // Example table numbers
            var c = await _couponServices.GetAllCouponsAsync();
            ViewBag.Coupons = c.Adapt<List<Coupon>>();
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddOrderVM vm)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.OrderTypes = Enum.GetValues(typeof(OrderType)).Cast<OrderType>().ToList();
                ViewBag.OrderStatuses = Enum.GetValues(typeof(OrderStatus)).Cast<OrderStatus>().ToList();
                ViewBag.Tables = new List<int> { 1, 2, 3, 4, 5 };
                var coupons = await _couponServices.GetAllCouponsAsync();
                ViewBag.Coupons = coupons;
                return View(vm);
            }
            else
            {
                ModelState.AddModelError("", "Please fill all required fields correctly.");
            }

            await _orderServices.AddAsync(vm);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var order = await _orderServices.GetByIdAsync(id);
            if (order == null) return NotFound();
            ViewBag.OrderTypes = Enum.GetValues(typeof(RMS.Core.Enum.OrderType)).Cast<RMS.Core.Enum.OrderType>().ToList();
            ViewBag.OrderStatuses = Enum.GetValues(typeof(RMS.Core.Enum.OrderStatus)).Cast<RMS.Core.Enum.OrderStatus>().ToList();
            ViewBag.Tables = new List<int> { 1, 2, 3, 4, 5 }; // Example table numbers
            var c = await _couponServices.GetAllCouponsAsync();
            ViewBag.Coupons = c.Adapt<List<Coupon>>();
            var updateVm = new UpdateOrderVM
            {
                OrderId = order.OrderId,
                DeliveryTime = order.DeliveryTime,
                Note = order.Note,
                DeliveryAddress = order.DeliveryAddress,
                CouponId = order.CouponId,
                TableId = order.TableId,
                OrderType = order.OrderType,
                OrderStatus = order.OrderStatus
            };

            return View(updateVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateOrderVM vm)
        {
            if (id != vm.OrderId) return BadRequest();

            if (!ModelState.IsValid)
            {
                ViewBag.OrderTypes = Enum.GetValues(typeof(RMS.Core.Enum.OrderType)).Cast<RMS.Core.Enum.OrderType>().ToList();
                ViewBag.OrderStatuses = Enum.GetValues(typeof(RMS.Core.Enum.OrderStatus)).Cast<RMS.Core.Enum.OrderStatus>().ToList();
                ViewBag.Tables = new List<int> { 1, 2, 3, 4, 5 }; // Example table numbers
                var c = await _couponServices.GetAllCouponsAsync();
                ViewBag.Coupons = c.Adapt<List<Coupon>>();
                return View(vm);
            }

            var updated = await _orderServices.UpdateAsync(id, vm);
            if (updated == null) return NotFound();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Cancel(int id)
        {
            var result = await _orderServices.CancelAsync(id);
            if (!result) return BadRequest();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _orderServices.DeleteAsync(id);
            if (!result) return BadRequest();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> AssignStaff(int id, string staffId)
        {
            var result = await _orderServices.AssignStaffAsync(id, staffId);
            if (!result) return BadRequest("Failed to assign staff");
            return RedirectToAction(nameof(Index));
        }
    }
}
