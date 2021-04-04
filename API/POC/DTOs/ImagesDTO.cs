using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace POC.DTOs
{
    public class ImagesDTO
    {
        [Required]
        public int image_id { get; set; }
        [Required]
        public string imageData { get; set; }
    }
}
