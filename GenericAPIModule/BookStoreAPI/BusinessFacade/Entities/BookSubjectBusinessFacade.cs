using BookStoreAPI.BusinessFacade.Interfaces;
using BookStoreAPI.DataAccessSQLServer.Entities;
using BookStoreAPI.Models.Entities;
using GenericAPIModule.BusinessFacade.Entities;
using GenericAPIModule.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BookStoreAPI.BusinessFacade.Entities
{
    public class BookSubjectBusinessFacade : GenericBusinessFacade<BookSubjectDTO>, IBookSubjectBusinessFacade
    {
        //public BookSubjectBusinessFacade()
        //{
        //    BookSubjectDataAccessSqlServer dataAccess = (BookSubjectDataAccessSqlServer)new GenericDataAccess<BookSubjectDTO>();
        //    dataAccess.SetDbConnection();
        //    base.SetDataAccess(dataAccess);
        //}

        //public void SetDataAccess()
        //{
        //    BookSubjectDataAccessSqlServer dataAccess = new BookSubjectDataAccessSqlServer();
        //    dataAccess.SetDbConnection();
        //    base.SetDataAccess(dataAccess);
        //}

        //public async Task<List<BookSubjectDTO>> ListAll(string query, params object[] args)
        //{
        //    return await base.ListAll(query, args);
        //}

        //public async Task<BookSubjectDTO> List(string query, params object[] args)
        //{
        //    return await base.List(query, args);
        //}

        //public async Task<BookSubjectDTO> Insert(string query, params object[] args)
        //{
        //    return await base.Insert(query, args);
        //}

        //public async Task<BookSubjectDTO> Update(string query, params object[] args)
        //{
        //    return await base.Update(query, args);
        //}

        //public async Task<BookSubjectDTO> Delete(string query, params object[] args)
        //{
        //    return await base.Delete(query, args);
        //}
    }
}