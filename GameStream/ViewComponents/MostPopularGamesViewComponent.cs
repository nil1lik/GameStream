using Microsoft.AspNetCore.Mvc;

namespace GameStream.ViewComponents
{
    public class MostPopularGamesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
