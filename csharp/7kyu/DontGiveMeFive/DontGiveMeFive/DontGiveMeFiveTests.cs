using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontGiveMeFive
{
    using NUnit.Framework;

    [TestFixture]
    public class KataTests
    {
        [Test]
        public void When_Distance_Between_Start_End_Is_Greater_Than_Zero_Then_Result_Should_Be_Greater_Than_Zero()
        {
            // Arrange
            int regionStart = 5;
            int regionEnd = 20;

            // Act
            int result = Kata.DontGiveMeFive(regionStart, regionEnd);

            // Assert
            Assert.GreaterOrEqual(result, 1);
        }

        [Test]
        public void When_Start_And_End_Are_Negative_Should_Give_Non_Negative_Result()
        {
            // Arrange
            int regionStart = -5;
            int regionEnd = -7;

            // Act
            var result = Kata.DontGiveMeFive(regionStart, regionEnd);

            // Assert
            Assert.GreaterOrEqual(result, 1);
        }

        [Test]
        public void When_Five_Is_In_Region_Then_Result_Should_Not_Include_Value()
        {
            // Arrange 
            int regionStart = 4;
            int regionEnd = 12;

            // Act
            var result = Kata.DontGiveMeFive(regionStart, regionEnd);

            // Assert
            Assert.AreEqual(regionEnd - regionStart, result);
        }
    }
}
