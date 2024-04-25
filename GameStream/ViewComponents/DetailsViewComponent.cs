using Microsoft.AspNetCore.Mvc;

namespace GameStream.ViewComponents
{
    public class DetailsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
