using Microsoft.AspNetCore.Mvc;

namespace GameStream.Controllers
{
    public class BrowseController : Controller
    {
        public IActionResult Browse()
        {
            return View();
        }
    }
}
