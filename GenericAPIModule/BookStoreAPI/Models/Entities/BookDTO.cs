using GenericAPIModule.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Models.Entities
{
    public class BookDTO : GenericDataModel
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public AuthorDTO AUTHOR { get; set; }
        public PublisherDTO PUBLISHER { get; set; }
    }
}