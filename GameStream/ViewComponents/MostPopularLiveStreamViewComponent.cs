using Microsoft.AspNetCore.Mvc;

namespace GameStream.ViewComponents
{
    public class MostPopularLiveStreamViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
