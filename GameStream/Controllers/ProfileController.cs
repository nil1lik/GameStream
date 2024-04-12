using Microsoft.AspNetCore.Mvc;

namespace GameStream.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
