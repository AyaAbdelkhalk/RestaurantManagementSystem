using Mapster;
using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.CategoryService;
using RMS.Application.ViewModels.CategoryViewModel;

namespace RMS.Presentation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _categoryService;
        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryService = categoryServices;
        }
        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategoriesAsync().Result;
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddCategoryVM model)
        {
            if (!ModelState.IsValid) return View(model);

            await _categoryService.AddCategoryAsync(model);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var existing = await _categoryService.GetCategoryByIdAsync(id);
            var model = existing?.Adapt<UpdateCategoryVM>();
            if (existing == null) return NotFound();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UpdateCategoryVM model)
        {
            if (!ModelState.IsValid) return View(model);
            var updated = await _categoryService.UpdateCategoryAsync(id, model);

            if (updated == null) return NotFound();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryService.GetCategoryByIdAsync(id);
            if (category == null) return NotFound();
            await _categoryService.DeleteCategoryAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
