using GenericAPIModule.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStoreAPI.Models.Entities
{
    public class PublisherDTO : GenericDataModel
    {
        [Display(Name = "Chave Primaria")]
        public int ID { get; set; }
        [Display(Name = "Nome")]
        public string NAME { get; set; }
        [Display(Name = "Endereço")]
        public string ADDRESS { get; set; }
        [Display(Name = "Número")]
        public string ADDRESS_NUMBER { get; set; }
        [Display(Name = "Complemento")]
        public string ADDRESS_NUMBER_COMPL { get; set; }
    }
}