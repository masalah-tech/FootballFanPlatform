using Dapper;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Saned.Data.Dapper
{
    public class Repository<T> : DbHelper, IRepository<T> where T : class
    {
        private IDbConnection db;
        public Repository(IDbConnection _db = null)
        {
            db = _db;

            //if (_db == null)
            //{
            //    using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            //    {
            //        db = myconnection;
            //    }
            //}
            //else
            //{
            //    db = _db;
            //}

        }

        public int Execute(string sql, T model)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return db.Execute(sql, model);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return myconnection.Execute(sql, model);
            }
        }

        public int ExecuteIdentity(string sql, T model)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return db.QueryFirst<int>(sql, model);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return myconnection.QueryFirst<int>(sql, model);
            }
        }


        public async Task<int> ExecuteAsync(string sql, T model)
        {
            if (db != null)
            {

                if (db.State == ConnectionState.Closed) db.Open();
                return await db.ExecuteAsync(sql, model);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();


                return await myconnection.ExecuteAsync(sql, model);
            }
        }

        public async Task<int> ExecuteIdentityAsync(string sql, object obj = null)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.QueryFirstAsync<int>(sql, obj);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.QueryFirstAsync<int>(sql, obj);
            }
        }

        public async Task<int> ExecuteStoredProcedureAsync(string procedureName, DynamicParameters parameters)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<int> ExecuteQueryAsync(string sql, object id = null)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.ExecuteAsync(sql, id);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.ExecuteAsync(sql, id);
            }
        }

        public int ExecuteQuery(string sql, object id = null)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return db.Execute(sql, id);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return myconnection.Execute(sql, id);
            }
        }

        public T Get(string sql, object id)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return db.QueryFirstOrDefault<T>(sql, id);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return myconnection.QueryFirstOrDefault<T>(sql, id);
            }
        }

        public IEnumerable<T> Query(string sql)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return db.Query<T>(sql);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return myconnection.Query<T>(sql);
            }
        }

        public async Task<T> GetAsync(string sql, object id)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.QueryFirstAsync<T>(sql, id);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.QueryFirstAsync<T>(sql, id);
            }
        }

        public IEnumerable<T> GetList(string sql)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return db.Query<T>(sql);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return myconnection.Query<T>(sql);
            }
        }

        public IEnumerable<T> GetListOfObject(string sql, object obj = null)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return db.Query<T>(sql, obj);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return myconnection.Query<T>(sql, obj);
            }
        }





        public List<string> GetList(string sql, object obj = null)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return db.Query<string>(sql, obj).AsList();
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return myconnection.Query<string>(sql, obj).AsList();
            }
        }

        public List<object> GetListOfList(string sql, object obj = null)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return db.Query<object>(sql, obj).AsList();
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return myconnection.Query<object>(sql, obj).AsList();
            }
        }

        public async Task<IEnumerable<T>> GetListAsync(string sql, object obj = null)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.QueryAsync<T>(sql, obj);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.QueryAsync<T>(sql, obj);
            }
        }

        public async Task<int> DeleteAsync(string sql, object id)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.ExecuteAsync(sql, id);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.ExecuteAsync(sql, id);
            }
        }
        public async Task<int> updateisread(string sql, object id)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.ExecuteAsync(sql, id);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.ExecuteAsync(sql, id);
            }
        }

        public int CountRows(string sql, object obj = null)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return db.QueryFirstOrDefault<int>(sql, obj);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return myconnection.QueryFirstOrDefault<int>(sql, obj);
            }
        }

        public async Task<int> ExecuteIdentityAsync(string sql, T model)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.QueryFirstAsync<int>(sql, model);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.QueryFirstAsync<int>(sql, model);
            }
        }
        public async Task<long> ExecuteIdentityLongAsync(string sql, T model)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.QueryFirstAsync<int>(sql, model);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.QueryFirstAsync<long>(sql, model);
            }
        }

        public async Task<string> ExecuteIdentityStringAsync(string sql, T model)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.QueryFirstAsync<string>(sql, model);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.QueryFirstAsync<string>(sql, model);
            }
        }

        public async Task<int> ExecuteIdentityIntAsync(string sql, T model)
        {
            if (db != null)
            {
                if (db.State == ConnectionState.Closed) db.Open();
                return await db.QueryFirstAsync<int>(sql, model);
            }
            using (IDbConnection myconnection = new SqlConnection(DbHelper.GetConnectionString()))
            {
                if (myconnection.State == ConnectionState.Closed) myconnection.Open();
                return await myconnection.QueryFirstAsync<int>(sql, model);
            }
        }
    }// end




}// NS
