using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class TigerTests
    {
        [TestMethod]
        public void MakeSound_ValidCat_MeowwwwExpected()
        {
            //Arrange
            Tiger tiger = new Tiger("Tycon", "Asia", 45, "Siama");

            //Act
            var actual = tiger.MakeSound();
            var expected = " <ROOARR ";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3VegetableGiven_3Expected()
        {
            //Arrange
            Tiger tiger = new Tiger("Tycon", "Asia", 45, "Siama");
            Food food = new Vegetable(3);

            //Act
            var actual = tiger.Eat(food);
            var expected = "Eat food.";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3MeatGiven_3Expected()
        {
            //Arrange
            Tiger tiger = new Tiger("Tycon", "Asia", 45, "Siama");
            Food food = new Meat(3);

            //Act
            var actual = tiger.Eat(food);
            var expected = "Eat food.";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_MinkaCat11HomePersian_CatMinkaPersian11Home0Expected()
        {
            //Arrange
            Tiger tiger = new Tiger("Tycon", "Asia", 45, "Siama");

            //Act
            var actual = tiger.ToString();
            var expected = "Tiger [animal name-Tycon, animal breed-Siama, animal weight-45," +
            " Region from-Asia, food pieces given-0]";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
