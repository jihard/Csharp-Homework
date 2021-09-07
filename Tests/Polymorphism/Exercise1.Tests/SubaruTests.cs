using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{

    [TestClass]
    public class SubaruTests
    {
        private Subaru _testCar;

        [TestMethod]
        public void SpeedUp_SpeedupCar_21Expected()
        {
            // Arrange
            _testCar = new Subaru();
            _testCar.SpeedUp();
            var expected = "21";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_BoostCar_3Expected()
        {
            // Arrange
            _testCar = new Subaru();
            _testCar.UseNitrousOxideEngine();
            var expected = "3";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpeedDown_SpeedDownCar_minus2Expected()
        {
            // Arrange
            _testCar = new Subaru();
            _testCar.SlowDown();
            var expected = "-2";

            // Act
            var actual = _testCar.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
