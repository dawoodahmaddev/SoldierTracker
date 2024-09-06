using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierTracker.Models
{
    public class Location
    {
        public int SensorID { get; set; }
        public Sensor Sensor { get; set; }

        public Guid SoldierID { get; set; }
        public Soldier Soldier { get; set; }

        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
    }
}
