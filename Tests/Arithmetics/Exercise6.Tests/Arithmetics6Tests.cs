using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class Arithmetics6Tests
    {
        [TestMethod]
        public void GetOutput_ReadsIndexOff5And3_ReturnsCozaLoza()
        {
            //Arrange
            var expeted = "CozaLoza ";

            // Act
            var actual = PositionChecher.GetOutput(15);
            
            // Assert
            Assert.AreEqual(actual, expeted);
        }

        [TestMethod]
        public void GetOutput_ReadsIndexOf21_ReturnsCozaWoza()
        {
            //Arrange
            var expected = "CozaWoza ";

            // Act
            var actual = PositionChecher.GetOutput(21);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void GetOutput_ReadsIndexOf3_ReturnsCoza()
        {
            //Arrange
            var expeted = "Coza ";

            //Act
            var actual = PositionChecher.GetOutput(3);

            //Assert
            Assert.AreEqual(actual, expeted);
        }

        [TestMethod]
        public void GetOutput_ReadsIndexOf5_ReturnsLoza()
        {
            //Arrange
            var expeted = "Loza ";

            //Act
            var actual = PositionChecher.GetOutput(5);

            //Assert
            Assert.AreEqual(actual, expeted);
        }

        [TestMethod]
        public void GetOutput_ReadsIndexOf7_ReturnsWoze()
        {
            //Arrange
            var expeted = "Woza ";

            //Act
            var actual = PositionChecher.GetOutput(7);
            
            //Assert
            Assert.AreEqual(actual, expeted);
        }
    }
}
