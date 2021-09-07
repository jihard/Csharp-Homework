using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class AudiTests
    {
        private Audi _testCar;

        [TestMethod]
        public void SpeedUp_SpeedUpCar_16Expected()
        {
            // Arrange
            _testCar = new Audi();
            _testCar.SpeedUp();
            var expected = "16";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpeedDown_SpeedDownCar_minus6Expected()
        {
            // Arrange
            _testCar = new Audi();
            _testCar.SlowDown();
            var expected = "-6";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
