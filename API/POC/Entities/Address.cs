using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POC.Entities
{
    public class Address
    {
        [Key]
        
        public int addr_id { get; set; }
        public string state { get; set; }
        public string city { get; set; }      
       
        public string landmark { get; set; }
        
        public int postal_code { get; set; }

        public bool isHome { get; set; }

        public bool isOffice { get; set; }

        public int user_id { get; set; }
    }
}

