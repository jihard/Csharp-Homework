using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise1.Tests
{
    [TestClass]
    public class LexusTests
    {
        private Lexus _testCar;

        [TestMethod]
        public void SpeedUp_SpeedUpCar_17Expected()
        {
            // Assert
            _testCar = new Lexus();
            _testCar.SpeedUp();
            var expected = "17";
            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_BoostCar_35Expected()
        {
            // Arrange
            _testCar = new Lexus();
            _testCar.UseNitrousOxideEngine();
            var expected = "35";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpeedDown_SpeedDownCar_minus3Expected()
        {
            // Assert
            _testCar = new Lexus();
            _testCar.SlowDown();
            var expected = "-3";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
