using GenericAPIModule.BusinessFacade.Entities;
using GenericAPIModule.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GenericAPIModule.Controllers.Entities
{
    public class GenericController<T>
    {
        private GenericBusinessFacade<T> _genericBusinessFacade = new GenericBusinessFacade<T>();

        public async Task<List<T>> ListAll(DbContext dbContext, string query, params object[] args)
        {
            Console.WriteLine();
            return await _genericBusinessFacade.ListAll(dbContext, query, args);
        }

        public async Task<T> List(DbContext dbContext, string query, params object[] args)
        {
            return await _genericBusinessFacade.List(dbContext, query, args);
        }

        public async Task<T> Insert(DbContext dbContext, string query, params object[] args)
        {
            return await _genericBusinessFacade.Insert(dbContext, query, args);
        }

        public async Task<T> Update(DbContext dbContext, string query, params object[] args)
        {
            return await _genericBusinessFacade.Update(dbContext, query, args);
        }

        public async Task<T> Delete(DbContext dbContext, string query, params object[] args)
        {
            return await _genericBusinessFacade.Delete(dbContext, query, args);
        }
    }
}