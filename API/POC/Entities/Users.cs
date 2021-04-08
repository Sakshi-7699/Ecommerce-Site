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
        public string email { get; set; }        
        public string pwd { get; set; }

        
    }
}

