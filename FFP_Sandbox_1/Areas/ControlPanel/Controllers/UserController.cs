using FFP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFP.Areas.ControlPanel.Controllers
{
    [Area("ControlPanel")]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Users =
                _context.Users
                .ToList();

            return View(Users);
        }

        public IActionResult Details(int id)
        {
            var user =
                _context.Users
                .Where(u => u.Id == id)
                .FirstOrDefault();

            return View(user);
        }

        public IActionResult Edit(int id)
        {
            var user =
                _context.Users
                .Where(u => u.Id == id)
                .FirstOrDefault();

            return View(user);
        }


    }
}
