using RMS.Application.ViewModels.OrderViewModel;
using RMS.Core.Enum;
using RMS.Core.Models;

namespace RMS.Application.Services.OrderService
{
    public interface IOrderServices
    {
        Task<List<OrderListVM>> GetAllAsync();
        Task<OrderDetailsVM?> GetByIdAsync(int id);
        Task<List<OrderListVM>> GetByCustomerIdAsync(string customerId);
        Task<List<OrderListVM>> GetByStaffIdAsync(string staffId);
        Task<List<OrderListVM>> GetByStatusAsync(OrderStatus status);
        Task<List<OrderListVM>> GetByTypeAsync(OrderType type);
        Task<List<OrderListVM>> GetByCouponAsync(int couponId);
        Task<List<OrderListVM>> GetCurrentCustomerOrdersAsync();
        Task<List<OrderListVM>> GetCurrentStaffOrdersAsync();

        Task<AddOrderVM> AddAsync(AddOrderVM vm);
        Task<bool> CancelAsync(int orderId);
        Task<bool> AssignStaffAsync(int orderId, string staffId);
        Task<UpdateOrderVM?> UpdateAsync(int orderId, UpdateOrderVM model);
        Task<bool> DeleteAsync(int orderId);
    }
}