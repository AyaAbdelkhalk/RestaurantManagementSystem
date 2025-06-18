using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.MenuItemService;

namespace RMS.Presentation.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly IMenuItemServices _menuItemServices;
        public MenuItemController(IMenuItemServices menuItemServices)
        {
            _menuItemServices = menuItemServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
