using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POC.Entities
{
    public class Products
    {
        [Key]
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }   
       
        public string product_image { get; set; }
        
        public int product_amount { get; set; }

        public int category_id { get; set; }

       
    }
}

