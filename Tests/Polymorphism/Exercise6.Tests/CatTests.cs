using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void MakeSound_ValidCat_MjjauExpected()
        {
            //Arrange
            Cat cat = new Cat("Tom", "Home", 10, "Persian");
            var expected = " <Mjjau ";

            //Act
            var actual = cat.MakeSound();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3VegetableGiven_3Expected()
        {
            //Arrange
            Cat cat = new Cat("Tom", "Home", 10, "Persian");
            Food food = new Vegetable(3);
            var expected = "Eat food.";

            //Act
            var actual = cat.Eat(food);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3MeatGiven_3Expected()
        {
            //Arrange
            Cat cat = new Cat("Tom", "Home", 10, "Persian");
            Food food = new Meat(3);
            var expected = "Eat food.";

            //Act
            var actual = cat.Eat(food);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_TomCat10HomePersian_CatTomPersian10HomeFoodPieces0Expected()
        {
            //Arrange
            Cat cat = new Cat("Tom","Home", 10, "Persian");
            var expected = "Cat [Tom, Persian, 10, Home, 0]";

            //Act
            var actual = cat.ToString();
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

