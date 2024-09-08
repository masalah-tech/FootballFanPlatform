using FFP.WebApp.Data.sql;
using FFP.WebApp.Models;
using NuGet.Protocol.Core.Types;
using Saned.Data.Dapper;

namespace FFP.WebApp.Data.Crud
{
    public class CountryLookupCrud : CountryLookupSqlScript
    {
        public async Task<IEnumerable<CountryLookup>> GetListAsync()
        {
            string query = GetListQuery();
            Repository<CountryLookup> crud = new Repository<CountryLookup>();

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
