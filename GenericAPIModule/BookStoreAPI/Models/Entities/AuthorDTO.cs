using GenericAPIModule.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Models.Entities
{
    public class AuthorDTO : GenericDataModel
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public DateTime? BIRTHDATE { get; set; }
    }
}