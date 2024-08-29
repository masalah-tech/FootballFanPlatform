using Microsoft.AspNetCore.Mvc;

namespace FFP.Controllers
{
    public class MatchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
