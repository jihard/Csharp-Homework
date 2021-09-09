using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise5.Tests
{
    [TestClass]
    public class Classesobjects5Tests
    {
        [TestMethod]
        public void DisplayDate_GetRightDataOutput_day21month7year2021Expected()
        {
            //Arrange
            DataExtensions _testdate = new DataExtensions(7, 21, 2021);
            string expected = "Entered Date is: 7/21/2021";

            //Act
            var actual = _testdate.DisplayDate(7, 21, 2021);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
