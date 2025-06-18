using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.Table;

namespace RMS.Presentation.Controllers
{
    public class TableController : Controller
    {
        private readonly ITableServices _tableServices;
        public TableController(ITableServices tableServices)
        {
            _tableServices = tableServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
