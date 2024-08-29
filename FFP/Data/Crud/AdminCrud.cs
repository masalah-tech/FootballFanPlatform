using FFP.Models;
using FFP.WebApp.Data.sql;
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
    }
}
