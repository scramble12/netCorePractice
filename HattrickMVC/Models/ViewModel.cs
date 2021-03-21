using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HattrickMVC.Models
{
    public class ViewModel
    {
        [Key]
        public int Id { get; set; }

        public IEnumerable<Nogomet> Nogomet { get; set; }
        public IEnumerable<PossibleTips>  PossibleTips{ get; set; }
        public IEnumerable<AvailableBetTypes>  AvailableBetTypes { get; set; }
        public IEnumerable<User> User { get; set; }
    }
}
