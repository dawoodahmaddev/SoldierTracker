using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierTracker.Models
{
    public class Soldier
    {
        public Soldier()
        {
            SoldierLocations = new HashSet<SoldierLocation>();
        }

        [Key]
        public Guid SoldierID { get; set; }
        public string Name { get; set; }
        public string TrainingInfo { get; set; }

        public int RankId { get; set; }
        [ForeignKey("RankId")]
        public Rank Rank { get; set; }

        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }

        public ICollection<SoldierLocation> SoldierLocations { get; set; }
    }
}
