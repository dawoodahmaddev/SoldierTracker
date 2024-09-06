using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierTracker.Models
{
    public class SoldierLocation : INotifyPropertyChanged
    {
        private int _SensorID;
        private Sensor _Sensor;
        private Guid _SoldierID;
        private Soldier _Soldier;
        private decimal _Latitude;
        private decimal _Longitude;

        public int SensorID { get { return _SensorID; } set { _SensorID = value; OnPropertyChanged(nameof(SensorID)); } }
        public Sensor Sensor { get { return _Sensor; } set { _Sensor = value; OnPropertyChanged(nameof(Sensor)); } }

        public Guid SoldierID { get { return _SoldierID; } set { _SoldierID = value; OnPropertyChanged(nameof(SoldierID)); } }
        public Soldier Soldier { get { return _Soldier; } set { _Soldier = value; OnPropertyChanged(nameof(Soldier)); } }

        public decimal Longitude { get { return _Longitude; } set { _Longitude = value; OnPropertyChanged(nameof(Longitude)); } }
        public decimal Latitude { get { return _Latitude; } set { _Latitude = value; OnPropertyChanged(nameof(Latitude)); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
