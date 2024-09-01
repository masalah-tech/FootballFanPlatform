using FFP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FFP.Areas.ControlPanel.Controllers
{
    [Area("ControlPanel")]
    public class AdminRoleController : Controller
    {
        public AdminRoleController()
        {
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult RoleAdmins(int id)
        {
            return View();
        }
    }
}
