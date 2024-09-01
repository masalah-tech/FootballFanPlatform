using FFP.Data;
using FFP.Models;
using FFP.WebApp.Data.Crud;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Saned.Data.Dapper;

namespace FFP.Areas.ControlPanel.Controllers
{
    [Area("ControlPanel")]
    public class AdminController : Controller
    {
        private readonly AdminCrud crud;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminController(IWebHostEnvironment webHostEnvironment)
        {
            crud = new AdminCrud();
            _webHostEnvironment = webHostEnvironment;
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

        public async Task<IActionResult> Upsert(int id)
        {
            ViewBag.AdminRoleList = (await crud.GetAdminRolesAsync())
                .Select(x => new SelectListItem
            {
                Text = x.Title,
                Value = x.Id.ToString()
            });

            return PartialView(new Admin());
        }

        [HttpPost]
        public async Task<IActionResult> Upsert(Admin model, IFormFile adminPhoto)
        {
            if (adminPhoto != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(adminPhoto.FileName);
                string profilePhotosPath = @"uploads/profile-photos";
                string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, profilePhotosPath);

                if (!Directory.Exists(finalPath))
                {
                    Directory.CreateDirectory(finalPath);
                }

                using (var fileStream = new FileStream(Path.Combine(finalPath, fileName), FileMode.Create))
                {
                    adminPhoto.CopyTo(fileStream);
                }

                model.PersonalPhotoPath = "/" + profilePhotosPath + "/" + fileName;
            }

            int res = await crud.AddAsync(model);

            return Json(new { success = true, message = "Record added successfully" });
        }
    }
}
