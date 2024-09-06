using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierTracker.Models
{
    public class Rank
    {
        [Key]
        public int RankId { get; set; }
        public string Name { get; set; }
    }
}
