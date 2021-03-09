using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HattrickMVC.Models
{
    public class Nogomet
    {
        [Key]
        public int SportId { get; set; }

        public String SportName { get; set; }

        public String EkipaDomacin { get; set; }

        public String EkipaGost { get; set; }

        public float bet1 { get; set; }

        public float bet2 { get; set; }
    }
}
