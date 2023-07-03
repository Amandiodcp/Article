using Microsoft.AspNetCore.Mvc;

namespace Quete1.Controllers
{
    public class TotoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tata()
        {
            return View();
        }
    }
}
