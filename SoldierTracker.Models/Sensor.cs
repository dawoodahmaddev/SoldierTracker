﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierTracker.Models
{
    public class Sensor
    {
        public Sensor()
        {
            SoldierLocations = new HashSet<SoldierLocation>();
        }
        [Key]
        public int SensorID { get; set; }
        public string SensorName { get; set; }
        public string SensorType { get; set; }

        public ICollection<SoldierLocation> SoldierLocations { get; set; }
    }
}
