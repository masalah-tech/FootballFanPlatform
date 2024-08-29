using FFP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFP.Areas.ControlPanel.Controllers
{
    [Area("ControlPanel")]
    public class MatchController : Controller
    {
        private readonly AppDbContext _context;

        public MatchController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var matches =
                _context.Matches
                .Include(m => m.Club1)
                .Include(m => m.Club2)
                .Include(m => m.League)
                .ToList();

            return View(matches);
        }
    }
}
