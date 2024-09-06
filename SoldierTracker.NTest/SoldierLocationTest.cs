using NUnit.Framework;
using SoldierTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierTracker.NTest
{
    [TestFixture]
    public class SoldierLocationTest
    {
        [Test]
        public void Location_ShouldHaveDefaultValues()
        {
            // Arrange
            var location = new SoldierLocation();

            // Assert
            Assert.AreEqual(default(int), location.SensorID);
            Assert.AreEqual(default(Guid), location.SoldierID);
            Assert.AreEqual(default(decimal), location.Longitude);
            Assert.AreEqual(default(decimal), location.Latitude);
        }

        [Test]
        public void Location_ShouldSetPropertiesCorrectly()
        {
            var soldierId = Guid.NewGuid();
            // Arrange
            var location = new SoldierLocation
            {
                SensorID = 1,
                SoldierID = soldierId,
                Longitude = 34.05m,
                Latitude = -118.24m
            };

            // Assert
            Assert.AreEqual(1, location.SensorID);
            Assert.AreEqual(soldierId, location.SoldierID);
            Assert.AreEqual(34.05, location.Longitude);
            Assert.AreEqual(-118.24, location.Latitude);
        }
    }
}
