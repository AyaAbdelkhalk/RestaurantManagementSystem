using Microsoft.EntityFrameworkCore;
using RMS.Application.Interfaces;
using RMS.Application.Services.UserService;
using RMS.Core.Enum;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly ICurrentUserService _currentUserService;

        public OrderRepository(RMSDbContext context, ICurrentUserService currentUserService) : base(context, currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public async Task<List<Order>> GetAllOrdersWithDetailsAsync()
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.AssignedStaff)
                .Include(o => o.Coupon)
                .Include(o => o.Table)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.MenuItem)
                .ToListAsync();

        }

        public Task<List<Order>> GetOrdersByCouponAsync(int couponId)
        {
            return _context.Orders
                .Include(o => o.OrderItems)
                .Include(c=>c.Coupon)
                .Where(o => o.CouponId == couponId)
                .ToListAsync();
        }

        public async Task<List<Order>> GetOrdersByCustomerAsync(string customerId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .Include(c => c.Coupon)
                .Include(o => o.Customer)
                .Where(o => o.CustomerId == customerId)
                .ToListAsync();
        }

        public async Task<List<Order>> GetOrdersByDateAsync(DateTime date)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .Include(o => o.Customer)
                .Include(c=>c.Coupon)
               .Where(o => o.CreatedAt.Date == date.Date)
               .ToListAsync();
        }

        public Task<List<Order>> GetOrdersByStaffAsync(string staffId)
        {
            return _context.Orders
                .Include(o => o.OrderItems)
                .Include(o => o.Customer)
                .Include(c => c.Coupon)
                .Where(o => o.AssignedStaffId == staffId)
                .ToListAsync();
        }

        public async Task<List<Order>> GetOrdersByStatusAsync(OrderStatus status)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .Include(o => o.Customer)
                .Where(o => o.OrderStatus == status)
                .ToListAsync();
        }

        public async Task<List<Order>> GetOrdersByTypeAsync(OrderType type)
        {
            return await _context.Orders
                .Where(o => o.OrderType == type)
                .ToListAsync();
        }

        public async Task<Order?> GetOrderWithDetailsAsync(int id)
        {
            return await _context.Orders
                .Include(o => o.Coupon)
                .Include(o => o.Customer)
                .Include(o => o.AssignedStaff)
                .Include(o => o.Table)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.MenuItem)
                .FirstOrDefaultAsync(o => o.OrderId == id);
        }
        public async Task<List<Order>> GetCurrentCustomerOrdersAsync()
        {
            var currentUserId = _currentUserService.GetCurrentUserId();
            return await _context.Orders
                .Include(o => o.OrderItems)
                .Where(o => o.CustomerId == currentUserId)
                .ToListAsync();
        }

        public async Task<List<Order>> GetCurrentStaffOrdersAsync()
        {
            var currentUserId = _currentUserService.GetCurrentUserId();
            return await _context.Orders
                .Include(o => o.OrderItems)
                .Where(o => o.AssignedStaffId == currentUserId)
                .ToListAsync();
        }
    }
  
}
