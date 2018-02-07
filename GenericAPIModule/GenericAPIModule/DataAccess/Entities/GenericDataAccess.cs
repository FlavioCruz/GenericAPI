using GenericAPIModule.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GenericAPIModule.DataAccess.Entities
{
    public class GenericDataAccess<T> : IGenericDataAccess<T>
    {

        public async Task<List<T>> ListAll(DbContext dbContext, string query, params object[] args)
        {
            return await dbContext.Database.SqlQuery<T>(query, args).ToListAsync();
        }

        public async Task<T> List(DbContext dbContext, string query, params object[] args)
        {
            return await dbContext.Database.SqlQuery<T>(query, args).SingleOrDefaultAsync();
        }

        public async Task<T> Insert(DbContext dbContext, string query, params object[] args)
        {
            return await dbContext.Database.SqlQuery<T>(query, args).SingleOrDefaultAsync();
        }

        public async Task<T> Update(DbContext dbContext, string query, params object[] args)
        {
            return await dbContext.Database.SqlQuery<T>(query, args).SingleOrDefaultAsync();
        }

        public async Task<T> Delete(DbContext dbContext, string query, params object[] args)
        {
            return await dbContext.Database.SqlQuery<T>(query, args).SingleOrDefaultAsync();
        }
    }
}