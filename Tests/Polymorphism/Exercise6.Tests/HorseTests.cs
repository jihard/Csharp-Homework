using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercise6.Tests
{
    [TestClass]
    public class HorseTests
    {
        [TestMethod]
        public void MakeSound_ValidHorse_HorseSoundExpected()
        {
            //Arrange
            Horse horse = new Horse("Ken", 45, "Latvia");
            var expected = " <Horse sound! ";

            //Act
            var actual = horse.MakeSound();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3VegetableGiven_3Expected()
        {
            //Arrange
            Horse horse = new Horse("Ken", 45, "Latvia");
            Food food = new Vegetable(3);
            var expected = "Eat food.";

            //Act
            var actual = horse.Eat(food);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3MeatGiven_3Expected()
        {
            //Arrange
            Horse horse = new Horse("Ken", 45, "Latvia");
            Food food = new Meat(3);
            var expected = "Eat food.";

            //Act
            var actual = horse.Eat(food);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_KenHorse45Latvia_HorseKen45Latvia0Expected()
        {
            //Arrange
            Horse horse = new Horse("Ken", 45, "Latvia");
            var expected = "Horse [Ken, 45, Latvia, 0]";

            //Act
            var actual = horse.ToString();
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
