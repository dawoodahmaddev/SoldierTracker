using SoldierTracker.Models;
using System.Collections.Generic;

namespace SoldierTracker.Services
{
    public interface ISoldierLocationService
    {
        List<SoldierLocation> GetSoldierLocations();
    }
}
