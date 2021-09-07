using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise7.Tests
{
    [TestClass]
    public class Arithmetics7Tests
    {
        [TestMethod]
        public void GetPosition_FallingTime9Velocity2Position54_minus325_305Expected()
        {
            //Arrange
            var fallingTime = 9;
            var initialVelocity = 2;
            var initialPosition = 54;

            //Act
            var actual = Program.GetPosition(fallingTime, initialVelocity, initialPosition);

            //Assert
            Assert.AreEqual(-325.305, actual);
        }
    }
}

