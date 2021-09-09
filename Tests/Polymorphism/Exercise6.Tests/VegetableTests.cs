using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class VegetableTest
    {
        
        [TestMethod]
        public void ToString_AnimalGets34PiecesOfVegetable_VegetableExpected()
        {
            //Arrange
            Vegetable veg = new Vegetable(34);
            var expected = "Vegetable";

            //Act
            var actual = veg.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
