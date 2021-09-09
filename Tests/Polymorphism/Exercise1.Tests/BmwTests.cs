using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise1.Tests
{
    [TestClass]
    public class BmwTests
    {
        private Bmw _testCar;

        [TestMethod]
        public void SpeedUp_SpeedUpCar_18Expected()
        {
            // Arrange
            _testCar = new Bmw();
            _testCar.SpeedUp();
            var expected = "18";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpeedDown_SpeedDownCar_minus9Expected()
        {
            // Arrange
            _testCar = new Bmw();
            _testCar.SlowDown();
            var expected = "-9";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
