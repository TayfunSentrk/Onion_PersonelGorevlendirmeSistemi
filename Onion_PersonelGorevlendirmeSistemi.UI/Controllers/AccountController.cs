using Microsoft.AspNetCore.Mvc;

namespace Onion_PersonelGorevlendirmeSistemi.UI.Controllers
{
    public class AccountController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
                return View();
        }



        public IActionResult Register()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            return View();
        }
    }
}
