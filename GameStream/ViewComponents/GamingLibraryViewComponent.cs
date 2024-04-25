using Microsoft.AspNetCore.Mvc;

namespace GameStream.ViewComponents
{
    public class GamingLibraryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
