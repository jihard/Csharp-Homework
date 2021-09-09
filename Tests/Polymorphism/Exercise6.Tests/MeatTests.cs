using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class MeatTest
    { 
        [TestMethod]
        public void ToString_AnimalGets34PiecesOfMeat_MeatExpected()
        {
            //Arrange
            Meat meat = new Meat(34);
            var expected = "Meat";

            //Act
            var actual = meat.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
