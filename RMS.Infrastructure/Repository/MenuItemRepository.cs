using Microsoft.EntityFrameworkCore;
using RMS.Application.Interfaces;
using RMS.Application.Services.UserService;
using RMS.Core.Models;

namespace RMS.Infrastructure.Repository
{
    public class MenuItemRepository : GenericRepository<MenuItem>, IMenuItemRepository
    {
        private readonly ICurrentUserService _currentUserService;

        public MenuItemRepository(RMSDbContext context, ICurrentUserService currentUserService) : base(context, currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public async Task<IQueryable<MenuItem>> GetMenuItemsByCategoryAsync(int categoryId)
        {
            return _context.MenuItems
                .Where(mi => mi.CategoryId == categoryId);
        }
        public async Task<MenuItem?> GetMenuItemWithDetailsAsync(int id)
        {
            return await _context.MenuItems
                .Include(mi => mi.Category)
                .Include(mi => mi.OrderItems)
                .FirstOrDefaultAsync(mi => mi.MenuItemId == id);
        }
        public async Task<IQueryable<MenuItem>> SearchMenuItemsAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return _context.MenuItems.AsQueryable();
            }

            return _context.MenuItems
                .Where(mi => (mi.Name != null && mi.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                             (mi.Description != null && mi.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)))
                ;
        }
        public async Task<IQueryable<MenuItem>> GetAvailableItemsAsync()
        {
            return _context.MenuItems
                .Where(mi => mi.IsAvailable);
        }
        public async Task<int> GetOrderCountTodayAsync(int menuItemId)
        {
            var today = DateTime.UtcNow.Date;
            return await _context.OrderItems
                .Include(oi => oi.Order)
                .Where(oi => oi.MenuItemId == menuItemId && oi.Order.CreatedAt.Date == today)
                .SumAsync(oi => oi.Quantity);
        }
        public async Task ResetDailyAvailabilityAsync()
        {
            var items = await _context.MenuItems.ToListAsync();
            foreach (var item in items)
            {
                item.IsAvailable = true;
                item.DailyOrderCount = 15;
            }
            await _context.SaveChangesAsync();
        }
        public async Task UpdateDailyOrderCountAsync(int menuItemId, int count)
        {
            var item = await _context.MenuItems.FindAsync(menuItemId);
            if (item != null)
            {
                item.DailyOrderCount += count;
                await _context.SaveChangesAsync();
            }
        }
    }
  
}
