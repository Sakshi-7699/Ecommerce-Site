using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace POC.DTOs
{
    public class ProductDetailsDTO
    {
        [Required]
        public int product_detail_id { get; set; }
        public string color { get; set; }
        public string brand { get; set; }

        public ImagesDTO product_image { get; set; }
    }
}
