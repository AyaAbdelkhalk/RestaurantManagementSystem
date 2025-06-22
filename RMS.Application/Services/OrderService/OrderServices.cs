using Mapster;
using RMS.Application.Interfaces;
using RMS.Application.Services.CouponService;
using RMS.Application.Services.UserService;
using RMS.Application.ViewModels.OrderViewModel;
using RMS.Core.Enum;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Services.OrderService
{
    public class OrderServices : IOrderServices
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICurrentUserService _currentUserService;
        private readonly ICouponServices _couponServices;
        public OrderServices(IOrderRepository orderRepository , ICurrentUserService currentUserService , ICouponServices couponServices)
        {
            _orderRepository = orderRepository;
            _currentUserService = currentUserService;
            _couponServices = couponServices;
        }

        public async Task<AddOrderVM> AddAsync(AddOrderVM vm)
        {
            var order = vm.Adapt<Order>();
            order.CustomerId = _currentUserService.GetCurrentUserId() ?? string.Empty;
            order.CouponId = vm.CouponId > 0 ? vm.CouponId : null;
            
            await _orderRepository.AddAsync(order);
            return vm;
        }

        public async Task<bool> AssignStaffAsync(int orderId, string staffId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            if (order == null) return false;
            order.AssignedStaffId = staffId;
            await _orderRepository.UpdateAsync(order);
            return true;
        }

        public async Task<bool> CancelAsync(int orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            if (order == null) return false;
            order.OrderStatus = OrderStatus.Cancelled;
            await _orderRepository.UpdateAsync(order);
            return true;
        }

        public async Task<bool> DeleteAsync(int orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            if (order == null) return false;
            await _orderRepository.DeleteAsync(orderId);
            return true;
        }

        public async Task<List<OrderListVM>> GetAllAsync()
        {
            var orders = await _orderRepository.GetAllOrdersWithDetailsAsync();
            return orders.Adapt<List<OrderListVM>>();
        }

        public async Task<List<OrderListVM>> GetByCouponAsync(int couponId)
        {
            var orders = await _orderRepository.GetOrdersByCouponAsync(couponId);
            return orders.Adapt<List<OrderListVM>>();
        }

        public async Task<List<OrderListVM>> GetByCustomerIdAsync(string customerId)
        {
            var orders = await _orderRepository.GetOrdersByCustomerAsync(customerId);
            return orders.Adapt<List<OrderListVM>>();
        }


        public async Task<OrderDetailsVM?> GetByIdAsync(int id)
        {
            var order = await _orderRepository.GetOrderWithDetailsAsync(id);
            if (order == null) return null;
           
            return order?.Adapt<OrderDetailsVM>();
        }

        public async Task<List<OrderListVM>> GetByStaffIdAsync(string staffId)
        {
            var orders = await _orderRepository.GetOrdersByStaffAsync(staffId);
            return orders.Adapt<List<OrderListVM>>();
        }

        public async Task<List<OrderListVM>> GetByStatusAsync(OrderStatus status)
        {
            var orders = await _orderRepository.GetOrdersByStatusAsync(status);
            return orders.Adapt<List<OrderListVM>>();
        }

        public async Task<List<OrderListVM>> GetByTypeAsync(OrderType type)
        {
            var orders = await _orderRepository.GetOrdersByTypeAsync(type);
            return orders.Adapt<List<OrderListVM>>();
        }

        public async Task<List<OrderListVM>> GetCurrentCustomerOrdersAsync()
        {
            var userId = _currentUserService.GetCurrentUserId();
            var orders = await _orderRepository.GetOrdersByCustomerAsync(userId);
            return orders.Adapt<List<OrderListVM>>();
        }

        public async Task<List<OrderListVM>> GetCurrentStaffOrdersAsync()
        {
            var userId = _currentUserService.GetCurrentUserId();
            var orders = await _orderRepository.GetOrdersByStaffAsync(userId);
            return orders.Adapt<List<OrderListVM>>();   
        }

        public async Task<UpdateOrderVM?> UpdateAsync(int orderId, UpdateOrderVM model)
        {
            var existingOrder = await _orderRepository.GetByIdAsync(orderId);
            if (existingOrder == null) return null;

            model.Adapt(existingOrder);
            await _orderRepository.UpdateAsync(existingOrder);
            return model;
        }
    }
}
