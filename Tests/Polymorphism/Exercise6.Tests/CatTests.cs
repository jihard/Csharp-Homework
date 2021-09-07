using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void MakeSound_ValidCat_MeowwwwExpected()
        {
            //Arrange
            Cat cat = new Cat("Tom", "Home", 10, "Persian");

            //Act
            var actual = cat.MakeSound();
            var expected = " <Mjjau ";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3VegetableGiven_3Expected()
        {
            //Arrange
            Cat cat = new Cat("Tom", "Home", 10, "Persian");
            Food food = new Vegetable(3);

            //Act
            var actual = cat.Eat(food);
            var expected = "Eat food.";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3MeatGiven_3Expected()
        {
            //Arrange
            Cat cat = new Cat("Tom", "Home", 10, "Persian");
            Food food = new Meat(3);

            //Act
            var actual = cat.Eat(food);
            var expected = "Eat food.";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_MinkaCat11HomePersian_CatMinkaPersian11Home0Expected()
        {
            //Arrange
            Cat cat = new Cat("Tom", "Home", 10, "Persian");

            //Act
            var actual = cat.ToString();
            var expected = "Cat [animal name-Tom, animal breed-Persian," +
            " animal weight-10, Region from-Home, food pieces given-0]";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

