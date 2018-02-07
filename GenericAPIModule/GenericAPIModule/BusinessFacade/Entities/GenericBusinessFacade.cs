using GenericAPIModule.BusinessFacade.Interfaces;
using GenericAPIModule.DataAccess.Entities;
using GenericAPIModule.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GenericAPIModule.BusinessFacade.Entities
{
    public class GenericBusinessFacade<T> : IGenericBusinessFacade<T>
    {

        protected GenericDataAccess<T> _dataAccess = new GenericDataAccess<T>();

        public async Task<List<T>> ListAll(DbContext dbContext, string query, params object[] args)
        {
            return await _dataAccess.ListAll(dbContext, query, args);
        }

        public async Task<T> List(DbContext dbContext, string query, params object[] args)
        {
            return await _dataAccess.List(dbContext, query, args);
        }

        public async Task<T> Insert(DbContext dbContext, string query, params object[] args)
        {
            return await _dataAccess.Insert(dbContext, query, args);
        }

        public async Task<T> Update(DbContext dbContext, string query, params object[] args)
        {
            return await _dataAccess.Update(dbContext, query, args);
        }

        public async Task<T> Delete(DbContext dbContext, string query, params object[] args)
        {
            return await _dataAccess.Delete(dbContext, query, args);
        }
    }
}