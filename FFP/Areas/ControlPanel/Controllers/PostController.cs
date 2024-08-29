using FFP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFP.Areas.ControlPanel.Controllers
{
    [Area("ControlPanel")]
    public class PostController : Controller
    {
        private readonly AppDbContext _context;

        public PostController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            var posts =
                _context.Posts
                .Include(p => p.User)
                .ToList();

            return View(posts);
        }

        public IActionResult Details(int id)
        {
            var post =
                _context.Posts
                .Where(p => p.Id == id)
                .Include(p => p.User)
                .FirstOrDefault();

            return View(post);
        }
    }
}
