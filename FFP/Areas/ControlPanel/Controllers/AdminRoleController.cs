using FFP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFP.Areas.ControlPanel.Controllers
{
    [Area("ControlPanel")]
    public class AdminRoleController : Controller
    {
        private readonly AppDbContext _context;

        public AdminRoleController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var adminRoles = _context.AdminRoles.ToList();

            return View(adminRoles);
        }

        public IActionResult RoleAdmins(int id)
        {
            var admins = 
                _context.Admins
                .Where(a => a.AdminRoleId == id)
                .Include(a => a.AdminRole)
                .Include(a => a.Address)
                .ToList();

            return View(admins);
        }
    }
}
