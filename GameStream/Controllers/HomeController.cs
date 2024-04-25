using Microsoft.AspNetCore.Mvc;

namespace GameStream.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Browse()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Streams()
        {
            return View();
        }
    }
}
