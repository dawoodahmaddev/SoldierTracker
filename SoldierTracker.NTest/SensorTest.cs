using NUnit.Framework;
using SoldierTracker.Models;
using System.ComponentModel.DataAnnotations;

namespace SoldierTracker.NTest
{
    [TestFixture]
    public class SensorTest
    {
        [Test]
        public void Sensor_ShouldHaveDefaultValues()
        {
            // Arrange
            var sensor = new Sensor();

            // Assert
            Assert.AreEqual(default(int), sensor.SensorID);
            Assert.AreEqual(default(string), sensor.SensorName);
            Assert.AreEqual(default(string), sensor.SensorType);
            Assert.IsNull(sensor.SensorName);
            Assert.IsNull(sensor.SensorType);
        }

        [Test]
        public void Sensor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var sensor = new Sensor
            {
                SensorName = "GPS",
                SensorType = "Location",
            };

            // Assert
            Assert.AreEqual("GPS", sensor.SensorName);
            Assert.AreEqual("Location", sensor.SensorType);
        }

    }
}