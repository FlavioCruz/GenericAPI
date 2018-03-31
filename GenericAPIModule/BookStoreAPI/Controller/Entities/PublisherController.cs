//using BookStoreAPI.BusinessFacade.Entities;
//using BookStoreAPI.DataAccessSQLServer.Utils;
using BookStoreAPI.Models.DB;
using BookStoreAPI.Models.Entities;
using GenericAPIModule.BusinessFacade.Entities;
using GenericAPIModule.Controllers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace BookStoreAPI.Controller.Entities
{
    public class PublisherController : GenericController<PublisherDTO>
    {


        public DBEntities db = new DBEntities();

        public async Task<List<PublisherDTO>> ListAllPublisher(string query, params object[] args)
        {
            return await base.ListAll(db, query, args);
        }

        public async Task<PublisherDTO> ListPublisher(string query, params object[] args)
        {
            return await base.List(db, query, args);
        }


        public async Task<PublisherDTO> InsertPublisher(string query, params object[] args)
        {
            return await base.List(db, query, args);
        }

        public async Task<PublisherDTO> UpdatePublisher(string query, params object[] args)
        {
            return await base.Update(db, query, args);
        }

        public async Task<PublisherDTO> DeletePublisher(string query, params object[] args)
        {
            return await base.Delete(db, query, args);
        }
    }
}