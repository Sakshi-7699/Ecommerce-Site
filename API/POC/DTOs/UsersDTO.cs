using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace POC.DTOs
{
    public class UsersDTO
    {
        [Key]
        public int user_id { get; set; }
        [Required]
        public string email { get; set; }
        public string pwd { get; set; }
    }
}
