using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace POC.DTOs
{
    public class UsersDTO
    {
        [Required]
        public int user_id { get; set; }
        public string first_name { get; set; }
        public string email { get; set; }
        public string last_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string phone { get; set; }
        public string pwd { get; set; }
    }
}
