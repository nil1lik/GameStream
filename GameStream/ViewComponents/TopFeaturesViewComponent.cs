using Microsoft.AspNetCore.Mvc;

namespace GameStream.ViewComponents
{
    public class TopFeaturesViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
