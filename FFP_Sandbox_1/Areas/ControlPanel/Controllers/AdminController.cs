using FFP.Data;
using FFP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFP.Areas.ControlPanel.Controllers
{
    [Area("ControlPanel")]
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var admins = 
                _context.Admins
                .Include(a => a.Address)
                .Include(a => a.AdminRole)
                .ToList();

            return View(admins);
        }

        public IActionResult Details(int id)
        {
            Admin admin =
                _context.Admins
                .Include(a => a.Address)
                .Include(a => a.AdminRole)
                .FirstOrDefault()!;

            return View(admin);
        }

        public IActionResult Edit(int id)
        {
            Admin admin =
                _context.Admins
                .Include(a => a.Address)
                .Include(a => a.AdminRole)
                .FirstOrDefault()!;

            return View(admin);
        }


    }
}
