using Microsoft.AspNetCore.Mvc;

namespace Restaurant.UI.Areas.Admin.ViewComponents.LayoutComponenets
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
