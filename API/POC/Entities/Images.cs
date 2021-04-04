using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POC.Entities
{
    public class Images
    {
        [Key]
        public int image_id { get; set; }
        [Required]
        public string imageData { get; set; }
    }
}
