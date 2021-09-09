using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise2.Tests
{
    [TestClass]
    public class Arithmetics2Test
    {
        private Program.Arithmetics2Extension _testNumber;

        [TestMethod]
        public void IsInputOddNumber_CheckForOdd_Number16IsTrue()
        {
            //Arrange
            _testNumber = new Program.Arithmetics2Extension(16);

            //Act
            var result = _testNumber.IsInput_OddNumber();

            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsInputOddNumber_CheckForOdd_Number17IsFalse()
        {
            //Arrange
            _testNumber = new Program.Arithmetics2Extension(17);

            //Act
            var result = _testNumber.IsInput_OddNumber();

            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
