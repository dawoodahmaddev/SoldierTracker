using Microsoft.EntityFrameworkCore;
using SoldierTracker.Data;
using SoldierTracker.Models;

namespace SoldierTracker.Services
{
    public class SoldierLocationService : ISoldierLocationService
    {
        public List<SoldierLocation> GetSoldierLocations()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.SoldierLocations
                              .Include(x => x.Sensor)
                              .Include(x => x.Soldier)
                              .Include(x => x.Soldier.Country)
                              .Include(x => x.Soldier.Rank)
                              .ToList();
            }
        }
    }
}
