﻿using FFP.Data;
using FFP.Models;
using FFP.WebApp.Data.Crud;
using FFP.WebApp.Data.ViewModels;
using FFP.WebApp.SD;
using FFP.WebApp.Services.IService;
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
        private readonly IFileUploader _fileUploader;

        public AdminController(IFileUploader fileUploader)
        {
            crud = new AdminCrud();
            _fileUploader = fileUploader;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetTableData(int draw, int start, int length)
        {
            var searchValue = Request.Form["search[value]"].FirstOrDefault();
            var sortColumnIndex = Convert.ToInt32(Request.Form["order[0][column]"]);
            var sortDirection = Request.Form["order[0][dir]"];

            IEnumerable<AdminVM> list = await crud.GetPagedListAsync(start, length, sortColumnIndex, sortDirection, searchValue);

            int recordsTotal = await crud.GetTotalCountAsync();

            int recordsFiltered = await crud.GetFilteredCountAsync(searchValue);

            return Json(new
            {
                draw = draw,
                recordsTotal = recordsTotal,
                recordsFiltered = recordsFiltered,
                data = list
            });
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

            ViewBag.CountryList = (await new CountryLookupCrud().GetListAsync())
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Name
                });

            return PartialView(new Admin());
        }

        [HttpPost]
        public async Task<IActionResult> Upsert(Admin model, IFormFile adminPhoto)
        {
            if (adminPhoto != null)
            {
                model.PersonalPhotoPath = 
                    await _fileUploader.Upload(adminPhoto, SdRelativePath.ProfilePhoto);
            }

            int res = await crud.AddAsync(model);

            return Json(new { success = true, message = "Record added successfully" });
        }
    }
}
