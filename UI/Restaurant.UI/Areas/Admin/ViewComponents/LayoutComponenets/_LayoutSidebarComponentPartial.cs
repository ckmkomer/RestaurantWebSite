using Microsoft.AspNetCore.Mvc;

namespace Restaurant.UI.Areas.Admin.ViewComponents.LayoutComponenets
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
