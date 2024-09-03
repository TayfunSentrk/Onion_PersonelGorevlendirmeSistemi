using Microsoft.AspNetCore.Mvc;

namespace Onion_PersonelGorevlendirmeSistemi.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
