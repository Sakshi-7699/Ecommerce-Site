using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POC.Entities
{
    public class Orders
    {
        [Key]
        public int order_id { get; set; }
        public int order_amount { get; set; }
        public bool order_status { get; set; }   
        public DateTime created_on { get; set; }   
        public string modified_on { get; set; }
        public int user_id { get; set; }   
        public int  addr_id { get; set; }
        public int discount_id { get; set; }
        public int cart_id { get; set; }
        
    }
}





