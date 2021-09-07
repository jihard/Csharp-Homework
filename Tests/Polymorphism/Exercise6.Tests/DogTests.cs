using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercise6.Tests
{
    [TestClass]
    public class DogTests
    {
        [TestMethod]
        public void MakeSound_ValidCat_MeowwwwExpected()
        {
            //Arrange
            Dog dog = new Dog("Spike", 23, "Streets");

            //Act
            var actual = dog.MakeSound();
            var expected = " <Wooff! ";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3VegetableGiven_3Expected()
        {
            //Arrange
            Dog dog = new Dog("Spike", 23, "Streets");
            Food food = new Vegetable(3);

            //Act
            var actual = dog.Eat(food);
            var expected = "Eat food.";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Eat_3MeatGiven_3Expected()
        {
            //Arrange
            Dog dog = new Dog("Spike", 23, "Streets");
            Food food = new Meat(3);

            //Act
            var actual = dog.Eat(food);
            var expected = "Eat food.";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_MinkaCat11HomePersian_CatMinkaPersian11Home0Expected()
        {
            //Arrange
            Dog dog = new Dog("Spike", 23, "Streets");

            //Act
            var actual = dog.ToString();
            var expected = "Dog [animal name-Spike, animal weight-23," +
            " Region from-Streets, food pieces given-0]";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
