using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GenericAPIModule.DataAccess.Interfaces
{
    public interface IGenericDataAccess<T>
    {
        Task<List<T>> ListAll(DbContext dbContext, string query, params object[] args);

        Task<T> List(DbContext dbContext, string query, params object[] args);

        Task<T> Insert(DbContext dbContext, string query, params object[] args);

        Task<T> Update(DbContext dbContext, string query, params object[] args);

        Task<T> Delete(DbContext dbContext, string query, params object[] args);
    }
}