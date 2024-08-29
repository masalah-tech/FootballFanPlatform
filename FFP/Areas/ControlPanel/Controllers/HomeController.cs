using Microsoft.AspNetCore.Mvc;

namespace FFP.Areas.ControlPanel.Controllers
{
    [Area("ControlPanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
