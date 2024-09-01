using FFP.Data;
using FFP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFP.Controllers
{
    public class FixtureController : Controller
    {
        public FixtureController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
