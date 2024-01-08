using Microsoft.AspNetCore.Mvc;
using OrganicStore.Models;

namespace OrganicStore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            string username = user.username;
            string password = user.password;
            
            return RedirectToAction("Products","Home", user);
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
