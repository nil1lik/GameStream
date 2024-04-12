using Microsoft.AspNetCore.Mvc;

namespace GameStream.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }
    }
}
