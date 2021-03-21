using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HattrickMVC.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public int novcanik { get; set; }
        
        public String listici { get; set; }
    }
}
