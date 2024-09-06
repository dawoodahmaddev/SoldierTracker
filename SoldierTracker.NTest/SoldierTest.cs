using NUnit.Framework;
using SoldierTracker.Models;
using System.ComponentModel.DataAnnotations;

namespace SoldierTracker.Tests
{
    [TestFixture]
    public class SoldierTests
    {
        [Test]
        public void Soldier_ShouldHaveDefaultValues()
        {
            // Arrange
            var soldier = new Soldier();

            // Assert
            Assert.IsNotNull(soldier.SoldierID);
            Assert.IsNull(soldier.Name);
            Assert.IsNull(soldier.TrainingInfo);
            Assert.IsNull(soldier.Rank);
            Assert.IsNull(soldier.Country);
        }

        [Test]
        public void Soldier_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var soldier = new Soldier
            {
                Name = "John Doe",
                TrainingInfo = "{\"trainingModules\": [\"Basic Combat\"]}",
                Rank = new Rank { RankId = 1, Name = "Sergeant" },
                Country = new Country { CountryId = 2, Name = "United States" }
            };

            // Assert
            Assert.AreEqual("John Doe", soldier.Name);
            Assert.AreEqual("{\"trainingModules\": [\"Basic Combat\"]}", soldier.TrainingInfo);
            Assert.AreEqual(1, soldier.Rank.RankId);
            Assert.AreEqual("Sergeant", soldier.Rank.Name);
            Assert.AreEqual(2, soldier.Country.CountryId);
            Assert.AreEqual("United States", soldier.Country.Name);
        }

    }
}