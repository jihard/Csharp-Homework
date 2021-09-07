using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class ToyotaTests
    {
        private Toyota _testsCar;

        [TestMethod]
        public void SpeedUp_SpeedUpCar_15Expected()
        {
            // Arrange
            _testsCar = new Toyota();
            _testsCar.SpeedUp();
            var expected = "15";

            // Act
            var actual = _testsCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpeedDown_SpeedDownCar_minus7Expected()
        {
            // Arrange
            _testsCar = new Toyota();
            _testsCar.SlowDown();
            var expected = "-7";

            // Act
            var actual = _testsCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
