using BookStoreAPI.Models.Entities;
using GenericAPIModule.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI.DataAccessSQLServer.Interfaces
{
    public interface IBookSubjectDataAccessSqlServer : IGenericDataAccess<BookSubjectDTO>
    {
    }
}
