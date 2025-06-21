using RMS.Application.ViewModels.MenuItemViewModel;
using RMS.Core.Models;

namespace RMS.Application.Services.MenuItemService
{
    public interface IMenuItemServices
    {
        //basic operations
        Task<List<GetMenuItemVM>?> GetAllAsync(bool onlyAvailable = false, int? categoryId = 0);
        Task<GetMenuItemVM?> GetByIdAsync(int id);
        Task<AddMenuItemVM> AddAsync(AddMenuItemVM model, string path);
        Task<UpdateMenuItemVM?> UpdateAsync(int id, UpdateMenuItemVM model);
        Task<bool> DeleteAsync(int id);
        Task<bool> CanBeDeletedAsync(int id);

        //other

        Task<bool> IsMenuItemAvailableAsync(int id);
        Task<int> GetOrderCountTodayAsync(int menuItemId);
        Task UpdateDailyOrderCountAsync(int menuItemId, int quantity);
        Task<List<GetMenuItemVM>> SearchAsync(string searchTerm, bool onlyAvailable = false, int? categoryId = 0);
        Task<int> GetPreparationTimeAsync(int menuItemId);

        //manage reset
        Task ResetDailyAvailabilityAsync();
        Task ResetDailyAvailabilityManuallyAsync(int menuItemId);
        Task ResetAllMenuItemsAvailabilityManuallyAsync();
    }
}