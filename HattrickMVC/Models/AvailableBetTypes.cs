using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HattrickMVC.Models
{
    public class AvailableBetTypes
    {
        [Key]
        public int id { get; set; }

        public int GameId { get; set; }

        public String AvialableBet { get; set; }
    }
}
