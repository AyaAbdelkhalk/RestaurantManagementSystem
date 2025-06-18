using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.MenuItem;

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
