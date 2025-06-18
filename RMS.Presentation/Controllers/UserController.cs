using Microsoft.AspNetCore.Mvc;
using RMS.Application.Services.UserService;

namespace RMS.Presentation.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices UserServices)
        {
            _userServices = UserServices;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
