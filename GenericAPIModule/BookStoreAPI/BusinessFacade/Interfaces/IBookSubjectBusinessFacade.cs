using BookStoreAPI.Models.DB;
using BookStoreAPI.Models.Entities;
using GenericAPIModule.BusinessFacade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreAPI.BusinessFacade.Interfaces
{
    interface IBookSubjectBusinessFacade : IGenericBusinessFacade<BookSubjectDTO>
    {
    }
}
