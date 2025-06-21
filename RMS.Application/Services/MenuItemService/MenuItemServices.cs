using Mapster;
using Microsoft.EntityFrameworkCore;
using RMS.Application.Interfaces;
using RMS.Application.ViewModels.MenuItemViewModel;
using RMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using RMS.Application.Helper;

namespace RMS.Application.Services.MenuItemService
{
    public class MenuItemServices : IMenuItemServices
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public MenuItemServices(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        //DON T FORGET image upload for menu items
        public async Task<AddMenuItemVM> AddAsync(AddMenuItemVM model,string imagesFolderPath)
        {
            var menuItem = model.Adapt<MenuItem>();
            if (model.Image != null)
            {
                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(model.Image.FileName);
                string filePath = Path.Combine(imagesFolderPath, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await model.Image.CopyToAsync(fileStream);

                }
                menuItem.ImageUrl = Path.Combine("Images", "MenuItems", uniqueFileName).Replace("\\", "/");
            }
            await _menuItemRepository.AddAsync(menuItem);
            return model;
        }

        public async Task<bool> CanBeDeletedAsync(int id)
        {
            var item = await _menuItemRepository.GetMenuItemWithDetailsAsync(id);
            return item?.OrderItems == null || !item.OrderItems.Any();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var canDelete = await CanBeDeletedAsync(id);
            if (!canDelete) return false;
            await _menuItemRepository.DeleteAsync(id);
            return true;
        }

        public async Task<List<GetMenuItemVM>?> GetAllAsync(bool onlyAvailable = false, int? categoryId = 0)
        {
            var query = _menuItemRepository.GetAllAsync();
            if (onlyAvailable)
            {
                query = query.Where(mi => mi.IsAvailable);
            }
            if (categoryId.HasValue && categoryId!=0)
            {
                query = query.Where(mi => mi.CategoryId == categoryId.Value);
            }
            return await query.Include(c=>c.Category).Select(x => x.Adapt<GetMenuItemVM>()).ToListAsync();

        }

        public async Task<GetMenuItemVM?> GetByIdAsync(int id)
        {
            var item = await _menuItemRepository.GetMenuItemWithDetailsAsync(id);
            return item?.Adapt<GetMenuItemVM>();
        }

        public Task<int> GetOrderCountTodayAsync(int menuItemId)
        {
            return _menuItemRepository.GetOrderCountTodayAsync(menuItemId);
        }

        public async Task<int> GetPreparationTimeAsync(int menuItemId)
        {
            var item = await _menuItemRepository.GetByIdAsync(menuItemId);
            return item?.PreparationTimeInMinutes ?? 0;
        }

        public async Task<bool> IsMenuItemAvailableAsync(int id)
        {
            var item = await _menuItemRepository.GetByIdAsync(id);
            return item?.IsAvailable ?? false;
        }

        public async Task ResetAllMenuItemsAvailabilityManuallyAsync()
        {
            var items = await _menuItemRepository.GetAllAsync().ToListAsync();
            foreach (var item in items)
            {
                item.IsAvailable = true;
                item.DailyOrderCount = 0;
                await _menuItemRepository.UpdateAsync(item);
            }
        }

        //hangfire
        public Task ResetDailyAvailabilityAsync()
        {
            return _menuItemRepository.ResetDailyAvailabilityAsync();
        }

        public async Task ResetDailyAvailabilityManuallyAsync(int menuItemId)
        {
            var item = await _menuItemRepository.GetByIdAsync(menuItemId);
            if (item != null)
            {
                item.IsAvailable = true;
                item.DailyOrderCount = 0;
                await _menuItemRepository.UpdateAsync(item);
            }
        }

        public async Task<List<GetMenuItemVM>> SearchAsync(string searchTerm, bool onlyAvailable = false, int? categoryId = 0)
        {
            var items = await _menuItemRepository.SearchMenuItemsAsync(searchTerm);
            if (onlyAvailable)
            {
                items = items.Where(mi => mi.IsAvailable);
            }
            if (categoryId.HasValue && categoryId != 0)
            {
                items = items.Where(mi => mi.CategoryId == categoryId.Value);
            }
            return items.Select(x => x.Adapt<GetMenuItemVM>()).ToList();
        }

        public async Task<UpdateMenuItemVM?> UpdateAsync(int id, UpdateMenuItemVM model)
        {
            var existingItem = await _menuItemRepository.GetByIdAsync(id);
            if (existingItem == null) { return null; }
            existingItem.Name = model.Name;
            existingItem.Description = model.Description;
            existingItem.UnitPrice = model.Price;
            existingItem.IsAvailable = model.IsAvailable;
            existingItem.PreparationTimeInMinutes = model.PreparationTime;
            existingItem.CategoryId = model.CategoryId;
            if (!string.IsNullOrEmpty(model.ImageUrl))
            {
                existingItem.ImageUrl = model.ImageUrl;
            }
            await _menuItemRepository.UpdateAsync(existingItem);
            return model;


        }

        public Task UpdateDailyOrderCountAsync(int menuItemId, int quantity)
        {
            return _menuItemRepository.UpdateDailyOrderCountAsync(menuItemId, quantity);
        }
    }
}
