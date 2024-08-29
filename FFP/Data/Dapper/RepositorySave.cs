using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Saned.Data.Dapper
{
    public class RepositorySave<T> : DbHelper, IRepository<T> where T : class
    {
        private IDbConnection db = new SqlConnection(GetConnectionString());
        public RepositorySave(IDbConnection _db = null)
        {
            if (_db != null)
                db = _db;
        }

        public int Execute(string sql, T model)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
                return myconnection.Execute(sql, model);
            }
        }

        public int ExecuteIdentity(string sql, T model)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.QueryFirst<int>(sql, model);
        }
        }


        public Task<int> ExecuteAsync(string sql, T model)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.ExecuteAsync(sql, model);
        }
        }

        public Task<int> ExecuteIdentityAsync(string sql, object obj = null)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.QueryFirstAsync<int>(sql, obj);
        }
        }

        public Task<int> ExecuteStoredProcedureAsync(string procedureName, DynamicParameters parameters)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
        }
        }

        public Task<int> ExecuteQueryAsync(string sql, object id = null)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.ExecuteAsync(sql, id);
        }
        }

        public int ExecuteQuery(string sql, object id = null)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.Execute(sql, id);
        }
        }

        public T Get(string sql, object id)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.QueryFirst<T>(sql, id);
        }
        }



        public IEnumerable<T> Query(string sql)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.Query<T>(sql);
        }
        }



        public Task<T> GetAsync(string sql, object id)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.QueryFirstAsync<T>(sql, id);
        }
        }

        public IEnumerable<T> GetList(string sql)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.Query<T>(sql);
        }
        }

        public IEnumerable<T> GetListOfObject(string sql, object obj = null)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.Query<T>(sql, obj);
        }
        }

        public List<string> GetList(string sql, object obj = null)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.Query<string>(sql, obj).AsList();
        }
        }

        public List<object> GetListOfList(string sql, object obj = null)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.Query<object>(sql, obj).AsList();
        }
        }

        public Task<IEnumerable<T>> GetListAsync(string sql, object obj = null)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.QueryAsync<T>(sql, obj);
        }
        }

        public Task<int> DeleteAsync(string sql, object id)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.ExecuteAsync(sql, id);
        }
        }

        public int CountRows(string sql, object obj = null)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.QueryFirst<int>(sql, obj);
        }
        }

        public Task<int> ExecuteIdentityAsync(string sql, T model)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.QueryFirstAsync<int>(sql, model);
        }
        }

        public Task<string> ExecuteIdentityStringAsync(string sql, T model)
        {
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                //if (db.State == ConnectionState.Closed) db.Open();
            return myconnection.QueryFirstAsync<string>(sql, model);
        }
        }
    }// end
}// NS
