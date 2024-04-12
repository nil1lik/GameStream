using Microsoft.AspNetCore.Mvc;

namespace GameStream.Controllers
{
    public class StreamsController : Controller
    {
        public IActionResult Streams()
        {
            return View();
        }
    }
}
