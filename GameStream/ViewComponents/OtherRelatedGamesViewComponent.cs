using Microsoft.AspNetCore.Mvc;

namespace GameStream.ViewComponents
{
    public class OtherRelatedGamesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}