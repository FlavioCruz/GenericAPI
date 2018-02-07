using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.DataAccessSQLServer.Utils
{
    public class Querys
    {
        public static readonly string ListAllBookSubject = "SELECT ID, TITLE FROM BOOK_SUBJECT";
    }
}