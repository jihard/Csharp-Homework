using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercise6.Tests
{
    [TestClass]
    public class HorseTests
    {
        [TestMethod]
        public void MakeSound_ValidCat_MeowwwwExpected()
        {
            //Arrange
            Horse horse = new Horse("Ken", 45, "Latvia");

            //Act
            var actual = horse.MakeSound();
            var expected = " <Horse sound! ";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3VegetableGiven_3Expected()
        {
            //Arrange
            Horse horse = new Horse("Ken", 45, "Latvia");
            Food food = new Vegetable(3);

            //Act
            var actual = horse.Eat(food);
            var expected = "Eat food.";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3MeatGiven_3Expected()
        {
            //Arrange
            Horse horse = new Horse("Ken", 45, "Latvia");
            Food food = new Meat(3);

            //Act
            var actual = horse.Eat(food);
            var expected = "Eat food.";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_MinkaCat11HomePersian_CatMinkaPersian11Home0Expected()
        {
            //Arrange
            Horse horse = new Horse("Ken", 45, "Latvia");

            //Act
            var actual = horse.ToString();
            var expected = "Horse [animal name-Ken, animal weight-45," +
            " Region from-Latvia, food pieces given-0]";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
