using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class Classesobject1Tests
    {
        [TestMethod]
        public void PrintProduct_PrintCorrectProduct_ReturnsExpectedProduct()
        {
            //Arrange
            ProductsExtensions product = new ProductsExtensions("IPhone", 134, 34, 514);
            var expected = "IPhone, price:  134  amount:  34";

            //Act
            var actual = product.PrintProduct("IPhone", 134, 34);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReduceAmount_ChangeProductAmountFrom36To35_Amount35Expected()
        {
            //Arrange
            ProductsExtensions product = new ProductsExtensions("IPhone", 134, 36, 514);
            var expected = 35;

            //Act
            var actual = product.ReduceAmount(35);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChangePrice_ChangeProductPriceFrom134To514_Price514Expected()
        {
            //Arrange
            ProductsExtensions product = new ProductsExtensions("IPhone", 134, 34, 514);
            var expected = 514;

            //Act
            var actual = product.ChangePrice(514, 134);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
