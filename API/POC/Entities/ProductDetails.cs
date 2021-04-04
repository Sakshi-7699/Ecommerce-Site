using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POC.Entities
{
    public class ProductDetails
    {
        [Key]
        public int product_detail_id { get; set; }
        public string color { get; set; }
        public string brand { get; set; }      
       
        
    }
}

