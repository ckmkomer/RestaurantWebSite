using Microsoft.AspNetCore.Mvc;

namespace Restaurant.UI.Areas.Admin.ViewComponents.LayoutComponenets
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
