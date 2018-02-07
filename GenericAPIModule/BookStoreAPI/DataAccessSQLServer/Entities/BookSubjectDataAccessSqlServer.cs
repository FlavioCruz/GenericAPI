using BookStoreAPI.DataAccessSQLServer.Entities;
using BookStoreAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStoreAPI.DataAccessSQLServer.Interfaces;
using GenericAPIModule.DataAccess.Entities;
using BookStoreAPI.Models.DB;
using System.Threading.Tasks;

namespace BookStoreAPI.DataAccessSQLServer.Entities
{
    public class BookSubjectDataAccessSqlServer : GenericDataAccess<BookSubjectDTO>, IBookSubjectDataAccessSqlServer
    {
        //private DBEntities context;
        
        //public BookSubjectDataAccessSqlServer()
        //{
        //    context = new DBEntities();
        //}

        //public void SetDbConnection()
        //{
        //    context = new DBEntities();
        //}

        //public async Task<List<BookSubjectDTO>> ListAll(string query, params object[] args)
        //{
        //    return await base.ListAll(context, query, args);
        //}

        //public async Task<BookSubjectDTO> List(string query, params object[] args)
        //{
        //    return await base.List(context, query, args);
        //}

        //public async Task<BookSubjectDTO> Insert(string query, params object[] args)
        //{
        //    return await base.Insert(context, query, args);
        //}

        //public async Task<BookSubjectDTO> Update(string query, params object[] args)
        //{
        //    return await base.Update(context, query, args);
        //}

        //public async Task<BookSubjectDTO> Delete(string query, params object[] args)
        //{
        //    return await base.Delete(context, query, args);
        //}

    }
}