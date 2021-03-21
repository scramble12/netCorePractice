using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HattrickMVC.Models
{
    public class PossibleTips
    {
        [Key]
        public int someId { get; set; }
        public int GameId { get; set; }

        public String BetType { get; set; } //osnovno, golovi...

        public String PossibleBet { get; set; } //1 2 X
        [Range(1.01, 999, ErrorMessage="Koef mora bit > 1")]
        public double Multiplier { get; set; }//1.24...
    }
}
