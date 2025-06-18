using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.Category;

namespace RMS.Presentation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _categoryServices;
        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
