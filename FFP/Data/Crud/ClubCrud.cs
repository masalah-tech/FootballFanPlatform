using FFP.Data.sql;
using FFP.Models;
using Saned.Data.Dapper;
using System.Data;

namespace FFP.Data.Crud
{
    public class ClubCrud : ClubSqlScript
    {
        Repository<Club> crud;

        public ClubCrud(IDbConnection dbConnection = null)
        {
            crud = new Repository<Club>(dbConnection);
        }

        public async Task<IEnumerable<Club>> GetListAsync()
        {
            string query = GetListQuery();

            try
            {
                return await crud.GetListAsync(query);
            }
            catch (Exception)
            {
                return new List<Club>();
            }
        }
    }
}
