using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class Arithmetics6Tests
    {
        [TestMethod]
        public void GetOutput_ReadsIndexOff5And3_ReturnsCozaLoza()
        {
            // Act
            var actual = PositionChecher.GetOutput(15);
            var expeted = "CozaLoza ";

            // Assert
            Assert.AreEqual(actual, expeted);
        }

        [TestMethod]
        public void GetOutput_ReadsIndexOf21_ReturnsCozaWoza()
        {
            // Act
            var actual = PositionChecher.GetOutput(21);
            var expected = "CozaWoza ";

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void GetOutput_ReadsIndexOf3_ReturnsCoza()
        {
            //Act
            var actual = PositionChecher.GetOutput(3);
            var expeted = "Coza ";

            //Assert
            Assert.AreEqual(actual, expeted);
        }

        [TestMethod]
        public void GetOutput_ReadsIndexOf5_ReturnsLoza()
        {
            //Act
            var actual = PositionChecher.GetOutput(5);
            var expeted = "Loza ";

            //Assert
            Assert.AreEqual(actual, expeted);
        }

        [TestMethod]
        public void GetOutput_ReadsIndexOf7_ReturnsWoze()
        {
            //Act
            var actual = PositionChecher.GetOutput(7);
            var expeted = "Woza ";

            //Assert
            Assert.AreEqual(actual, expeted);
        }
    }
}
