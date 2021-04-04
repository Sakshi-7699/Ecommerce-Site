using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.DTOs
{
    public class CartDTO
    {
        public int cart_id { get; set; }
        public int quantity { get; set; }
        public int user_id { get; set; }
        public int product_id { get; set; }
    }
}
