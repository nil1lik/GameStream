using Microsoft.AspNetCore.Mvc;

namespace GameStream.ViewComponents
{
    public class FeaturedGamesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
