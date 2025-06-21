using Mapster;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.CategoryService;
using RMS.Application.Services.MenuItemService;
using RMS.Application.ViewModels.MenuItemViewModel;
using System.Threading.Tasks;

namespace RMS.Presentation.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly IMenuItemServices _menuItemService;
        private readonly ICategoryServices _categoryService; 
        private readonly IWebHostEnvironment _env;
        public MenuItemController(IMenuItemServices menuItemServices, IWebHostEnvironment env, ICategoryServices categoryService)
        {
            _menuItemService = menuItemServices;
            _env = env;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var menuItems = await _menuItemService.GetAllAsync(onlyAvailable: false, categoryId: 0);
            if (menuItems == null || !menuItems.Any())
            {
                return View("NoDataFound"); // You can create a view for no data found
            }
            return View(menuItems);
        }
        public async Task<IActionResult> Create()
        {
            //list of categories can be passed here if needed
            var categories = await _categoryService.GetAllCategoriesAsync();
            ViewBag.Categories = categories;    
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddMenuItemVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var imagesFolderPath = Path.Combine(_env.WebRootPath, "Images", "MenuItems");
            if (!Directory.Exists(imagesFolderPath))
                Directory.CreateDirectory(imagesFolderPath);

            await _menuItemService.AddAsync(model, imagesFolderPath);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var menuItem = await _menuItemService.GetByIdAsync(id);
            if (menuItem == null)
            {
                return NotFound();
            }
            var categories = await _categoryService.GetAllCategoriesAsync();
            ViewBag.Categories = categories;
            // Map the menu item to the update view model
            return View(menuItem.Adapt<UpdateMenuItemVM>());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateMenuItemVM model)
        {

            if (id != model.MenuItemId)
            {
                return BadRequest("Menu item ID mismatch.");
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ViewBag.Categories = await _categoryService.GetAllCategoriesAsync();

            if (model.Image != null && model.Image.Length > 0)
            {
                //delete old image if exists
                var existingItem = await _menuItemService.GetByIdAsync(id);
                if (existingItem != null && !string.IsNullOrEmpty(existingItem.ImageUrl))
                {
                    var oldImagePath = Path.Combine(_env.WebRootPath, existingItem.ImageUrl.TrimStart('/'));
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }
                string uploadsFolder = Path.Combine(_env.WebRootPath, "Images", "MenuItems");
                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(model.Image.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await model.Image.CopyToAsync(fileStream);
                }

                model.ImageUrl = Path.Combine("Images", "MenuItems", uniqueFileName).Replace("\\", "/");
            }


            var updatedItem = await _menuItemService.UpdateAsync(id, model);
            if (updatedItem == null)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (!await _menuItemService.CanBeDeletedAsync(id))
            {
                ModelState.AddModelError("", "This menu item cannot be deleted because it has been ordered today.");
                return RedirectToAction(nameof(Index));
            }
            var result = await _menuItemService.DeleteAsync(id);
            if (!result)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }


        }
}
