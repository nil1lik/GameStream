using Microsoft.AspNetCore.Mvc;

namespace GameStream.ViewComponents
{
    public class InformationBoxViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
