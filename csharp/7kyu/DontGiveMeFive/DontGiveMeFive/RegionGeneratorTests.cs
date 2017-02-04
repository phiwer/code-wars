using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGiveMeFive
{
    using NUnit.Framework;

    [TestFixture]
    public class RegionGeneratorTests
    {
        [Test]
        public void Constructor_Should_Set_Initial_Values()
        {
            // Arrange
            int regionStartNumber = 5;
            int regionEndNumber = 20;

            // Act
            var regionGenerator = new RegionGenerator(regionStartNumber, regionEndNumber);

            // Assert
            Assert.AreEqual(regionStartNumber, regionGenerator.StartNumber);
            Assert.AreEqual(regionEndNumber, regionGenerator.EndNumber);
        }

        [Test]
        public void Generating_Region_Should_Set_Generated_Values()
        {
            // Arrange
            int regionStartNumber = 5;
            int regionEndNumber = 20;

            var regionGenerator = new RegionGenerator(regionStartNumber, regionEndNumber);

            // Act
            regionGenerator.GenerateRegionValues();

            // Assert
            Assert.GreaterOrEqual(regionGenerator.Values.Count(), 1);
        }

        [Test]
        public void Generating_With_Filter_Should_Remove_Value_From_Result()
        {
            // Arrange
            var filteredNumber = 5;
            int regionStartNumber = 5;
            int regionEndNumber = 7;

            var regionGenerator = new RegionGenerator(regionStartNumber, regionEndNumber, filteredNumber);

            // Act
            regionGenerator.GenerateRegionValues();

            // Assert
            CollectionAssert.AreEqual(new List<int> {6, 7},  regionGenerator.Values);
        }
    }


}
