using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6.Tests
{
    [TestClass]
    public class Colletieons6Tests
    {
        string[] arrayFromText =
        {
            "San Jose -> San Francisco",
            "San Jose -> Anchorage",
            "New York -> Anchorage",
            "New York -> San Jose",
            "New York -> San Francisco",
            "New York -> Honolulu",
            "Anchorage -> New York",
            "Anchorage -> San Jose",
            "Honolulu -> New York",
            "Honolulu -> San Francisco",
            "San Francisco -> New York",
            "San Francisco -> Honolulu" ,
            "Denver -> San Jose",
            "San Francisco -> Denver"
        };
        [TestMethod]
        public void AvailableCitis_CountUniqueCities_NumberOfUniqueCitiesExpected6()
        {
            //Arrange
            var expected = 6;

            //Act
            var actual = Colletions6Extensions.AvailableCitis(arrayFromText);

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }

        [TestMethod]
        public void GetRoutes_GetRightRoute_ExpectedToChooseCorrectFlightRoute()
        {
            //Arrange
            string[] text = { "New York -> Honolulu", "New York -> San Francisco" };
            var expected = "New York";
            var list = new List<string>() { "Honolulu", "San Francisco" };

            //Act
            var actual = Colletions6Extensions.GetRoutes(text);

            //Assert            
            Assert.AreEqual(list[0], actual[expected][0]);
            Assert.AreEqual(list[1], actual[expected][1]);
        }
    }
}
