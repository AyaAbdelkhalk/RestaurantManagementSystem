using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Application.Interfaces
{
    public interface IMenuItemRepository : IGenericRepository<MenuItem>
    {
        Task<IQueryable<MenuItem>> GetMenuItemsByCategoryAsync(int categoryId);
        Task<MenuItem?> GetMenuItemWithDetailsAsync(int id);
        Task<IQueryable<MenuItem>> SearchMenuItemsAsync(string searchTerm);
        Task<IQueryable<MenuItem>> GetAvailableItemsAsync();
        Task<int> GetOrderCountTodayAsync(int menuItemId);
        Task ResetDailyAvailabilityAsync();
        Task UpdateDailyOrderCountAsync(int menuItemId, int count);

    }
}
