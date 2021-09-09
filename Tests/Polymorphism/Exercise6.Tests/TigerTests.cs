using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class TigerTests
    {
        [TestMethod]
        public void MakeSound_ValidTiger_ROOARRExpected()
        {
            //Arrange
            Tiger tiger = new Tiger("Tycon", "Asia", 45, "Siama");
            var expected = " <ROOARR ";

            //Act
            var actual = tiger.MakeSound();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3VegetableGiven_3Expected()
        {
            //Arrange
            Tiger tiger = new Tiger("Tycon", "Asia", 45, "Siama");
            Food food = new Vegetable(3);
            var expected = "Vegetable";

            //Act
            var actual = tiger.Eat(food);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3MeatGiven_3Expected()
        {
            //Arrange
            Tiger tiger = new Tiger("Tycon", "Asia", 45, "Siama");
            Food food = new Meat(3);
            var expected = "Vegetable";

            //Act
            var actual = tiger.Eat(food);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_TyconTiger45AsiaSiama_TigerTyconSiama45AsiaFoodPieces0Expected()
        {
            //Arrange
            Tiger tiger = new Tiger("Tycon", "Asia", 45, "Siama");
            var expected = "Tiger [Tycon, Siama, 45, Asia, 0]";

            //Act
            var actual = tiger.ToString();
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
