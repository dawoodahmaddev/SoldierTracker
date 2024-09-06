using Microsoft.EntityFrameworkCore;
using SoldierTracker.Data;
using SoldierTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierTracker.ViewModels
{
    public class SoldierLocationViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<SoldierLocation> _soldierLocations;
        public ObservableCollection<SoldierLocation> SoldierLocations
        {
            get { return _soldierLocations; }
            set { _soldierLocations = value; OnPropertyChanged(nameof(SoldierLocations)); }
        }

        public SoldierLocationViewModel()
        {
            LoadLocations();
        }

        private void LoadLocations()
        {
            using (var context = new ApplicationDbContext())
            {
                SoldierLocations = new ObservableCollection<SoldierLocation>
                    (context.SoldierLocations
                            .Include(x => x.Sensor)
                            .Include(x => x.Soldier)
                            .Include(x=> x.Soldier.Country)
                            .Include(x=> x.Soldier.Rank)
                            .ToList());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
