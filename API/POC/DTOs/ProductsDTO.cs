using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace POC.DTOs
{
    public class ProductsDTO
    {
        [Required]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }       
        public int product_amount { get; set; }
        public int category_id { get; set; }
    }
}
