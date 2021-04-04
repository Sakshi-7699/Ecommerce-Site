using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace POC.Entities
{
    public class Users
    {
        [Key]
        public int user_id { get; set; }
        [Required]
        public string first_name { get; set; }
        public string last_name { get; set; }      
        public DateTime date_of_birth { get; set; }
        public string phone { get; set; }
        public string pwd { get; set; }

        
    }
}

