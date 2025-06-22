using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Core.Enum;
using RMS.Core.Models;

namespace RMS.Application.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<Order?> GetOrderWithDetailsAsync(int id);
        Task<List<Order>> GetAllOrdersWithDetailsAsync();
        Task<List<Order>> GetOrdersByCustomerAsync(string customerId);
        Task<List<Order>> GetOrdersByStaffAsync(string staffId);
        Task<List<Order>> GetOrdersByDateAsync(DateTime date);
        Task<List<Order>> GetOrdersByStatusAsync(OrderStatus status);
        Task<List<Order>> GetOrdersByTypeAsync(OrderType type);
        Task<List<Order>> GetOrdersByCouponAsync(int couponId);
        Task<List<Order>> GetCurrentCustomerOrdersAsync();
        Task<List<Order>> GetCurrentStaffOrdersAsync();

    }
}
