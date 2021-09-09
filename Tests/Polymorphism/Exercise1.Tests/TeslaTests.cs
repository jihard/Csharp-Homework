using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise1.Tests
{
    [TestClass]
    public class TeslaTests
    {
        private Tesla _testCar;

        [TestMethod]
        public void SpeedUp_SpeedUpCar_12Expected()
        {
            // Arrange
            _testCar = new Tesla();
            _testCar.SpeedUp();
           
            var expected = "12";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SpeedDown_SpeedDownCar_minus5Expected()
        {
            // Arrange
            _testCar = new Tesla();
            _testCar.SlowDown();
            var expected = "-5";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
