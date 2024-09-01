using FFP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFP.Areas.ControlPanel.Controllers
{
    [Area("ControlPanel")]
    public class MatchController : Controller
    {
        public MatchController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
