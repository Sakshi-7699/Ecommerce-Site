using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POC.Entities
{
    public class Cart
    {
        [Key]
        public int cart_id { get; set; }
        public int user_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
    }
}
