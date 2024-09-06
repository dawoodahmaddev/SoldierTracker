using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierTracker.Models
{
    public class Soldier
    {
        [Key]
        public Guid SoldierID { get; set; }
        public string Name { get; set; }
        public string TrainingInfo { get; set; }
    }
}
