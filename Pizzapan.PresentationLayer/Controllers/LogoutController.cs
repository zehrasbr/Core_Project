using Microsoft.AspNetCore.Mvc;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
