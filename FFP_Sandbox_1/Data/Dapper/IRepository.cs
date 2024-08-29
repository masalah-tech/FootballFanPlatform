using System.Collections.Generic;
using System.Threading.Tasks;

namespace Saned.Data.Dapper
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetList(string sql);
        Task<IEnumerable<T>> GetListAsync(string sql, object obj = null);
        T Get(string sql, object id);
        Task<T> GetAsync(string sql, object id);
        int Execute(string sql, T model);
        int ExecuteIdentity(string sql, T model);
        Task<int> ExecuteAsync(string sql, T model);
        Task<int> ExecuteIdentityAsync(string sql, T model);
        Task<int> DeleteAsync(string sql, object id);
        int CountRows(string sql, object obj = null);

    }// end
}// NS
