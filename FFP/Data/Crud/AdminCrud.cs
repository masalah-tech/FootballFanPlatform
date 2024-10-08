﻿using FFP.Models;
using FFP.WebApp.Data.sql;
using FFP.WebApp.Data.ViewModels;
using NuGet.Protocol.Core.Types;
using Saned.Data.Dapper;

namespace FFP.WebApp.Data.Crud
{
    public class AdminCrud : AdminSqlScript
    {
        public async Task<IEnumerable<Admin>> GetListAsync()
        {
            string query = GetListQuery();
            Repository<Admin> crud = new Repository<Admin>();

            try
            {
                return await crud.GetListAsync(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<AdminVM>> GetPagedListAsync(int start, int length, int sortColumnIndex, string sortDirection, string searchValue)
        {
            string query = GetPagedListQuery(start, length, sortColumnIndex, sortDirection);
            Repository<AdminVM> crud = new Repository<AdminVM>();

            try
            {
                return await crud.GetListAsync(query, new
                {
                    SearchValue = $"%{searchValue}%"
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> GetTotalCountAsync()
        {
            string query = GetTotalCountQuery();
            Repository<string> crud = new Repository<string>();

            try
            {
                return Convert.ToInt32(await crud.GetAsync(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<int> GetFilteredCountAsync(string searchValue)
        {
            string query = GetFilteredCountQuery();
            Repository<string> crud = new Repository<string>();

            try
            {
                return Convert.ToInt32(await crud.GetAsync(query, new { SearchValue = $"%{searchValue}%" }));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<int> AddAsync(Admin model)
        {
            string query = AddQuery();
            Repository<object> crud = new Repository<object>();

            try
            {
                return await crud.ExecuteIdentityIntAsync(query, FalttenAdminModel(model));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<AdminRole>> GetAdminRolesAsync()
        {
            string query = GetAdminRolesQuery();
            Repository<AdminRole> crud = new Repository<AdminRole>();

            try
            {
                return await crud.GetListAsync(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #region Private Helpers

        private object FalttenAdminModel(Admin model)
            => new
            {
                model.Username,
                model.EncPassword,
                model.AdminRoleId,
                model.FirstName,
                model.SecondName,
                model.ThirdName,
                model.LastName,
                model.BirthDate,
                model.PersonalPhotoPath,
                model.Email,
                model.PhoneNumber,
                model.Nationality,
                model.Status,
                Country = model.Address.Country,
                City = model.Address.City,
                Street = model.Address.Street,
                AppartmentNo = model.Address.AppartmentNo,
                ZipCode = model.Address.ZipCode
            };

        #endregion
    }
}
