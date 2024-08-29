using FFP.Data;
using FFP.Models;
using FFP.WebApp.Data.Crud;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Saned.Data.Dapper;

namespace FFP.Areas.ControlPanel.Controllers
{
    [Area("ControlPanel")]
    public class AdminController : Controller
    {
        private readonly AdminCrud crud;

        public AdminController()
        {
            crud = new AdminCrud();
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Admin> list = await crud.GetListAsync();

            return View(list);
        }

        public IActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return View();
        }


    }
}
