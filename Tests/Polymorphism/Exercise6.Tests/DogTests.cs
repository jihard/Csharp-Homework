using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercise6.Tests
{
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        public void MakeSound_ValidDog_WooffExpected()
        {
            //Arrange
            Dog dog = new Dog("Spike", 23, "Streets");
            var expected = " <Wooff! ";

            //Act
            var actual = dog.MakeSound();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3VegetableGiven_3Expected()
        {
            //Arrange
            Dog dog = new Dog("Spike", 23, "Streets");
            Food food = new Vegetable(3);
            var expected = "Eat food.";

            //Act
            var actual = dog.Eat(food);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3MeatGiven_3Expected()
        {
            //Arrange
            Dog dog = new Dog("Spike", 23, "Streets");
            Food food = new Meat(3);
            var expected = "Eat food.";

            //Act
            var actual = dog.Eat(food);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_SpikeDog23Streets_DogSpike23StreetsFoodPieces0Expected()
        {
            //Arrange
            Dog dog = new Dog("Spike", 23, "Streets");
            var expected = "Dog [Spike, 23, Streets, 0]";

            //Act
            var actual = dog.ToString();
   
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
