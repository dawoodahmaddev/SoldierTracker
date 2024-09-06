using Microsoft.EntityFrameworkCore;
using SoldierTracker.Data;
using SoldierTracker.Models;
using SoldierTracker.Services;
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
        private readonly ISoldierLocationService _soldierLocationService;
        private ObservableCollection<SoldierLocation> _soldierLocations;

        public ObservableCollection<SoldierLocation> SoldierLocations
        {
            get { return _soldierLocations; }
            set { _soldierLocations = value; OnPropertyChanged(nameof(SoldierLocations)); }
        }

        public SoldierLocationViewModel(ISoldierLocationService soldierLocationService)
        {
            _soldierLocationService = soldierLocationService;
            LoadLocations();
        }

        private void LoadLocations()
        {
            var locations = _soldierLocationService.GetSoldierLocations();
            SoldierLocations = new ObservableCollection<SoldierLocation>(locations);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
