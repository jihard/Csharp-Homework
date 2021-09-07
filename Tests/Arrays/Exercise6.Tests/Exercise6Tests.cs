using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Exercise6.Tests
{
    [TestClass]
    public class Exercise6Tests
    {
        [TestMethod]
        public void CreatingArray_InputNumber10_ArrayWithSizeOf10Elements()
        {
            //Arrange
            var userInput = 10;

            //Act
            var actual = ArrayExtension.CreatingArray(userInput);

            //Assert
            Assert.AreEqual(userInput, actual.Length);
        }

        [TestMethod]
        public void CopyOriginalArray_MakeArraysCopye_CopiedOriginalArray()
        {
            //Arrange
            var arrayOfNumbers = new int[10];

            //Act
            var actual = ArrayExtension.CopyOriginalArray(arrayOfNumbers);

            //Assert
            CollectionAssert.AreEqual(arrayOfNumbers, actual);
        }

        [TestMethod]
        public void CopyOriginalArray_ChangingArraysLastelement_ArrayLastValueExpectedMinus7()
        {
            //Arrange
            var arrayOfNumbers = new int[10];

            //Act
            var expectedValue = -7;
            var actual = ArrayExtension.CopyOriginalArray(arrayOfNumbers);

            //Assert
            ArrayExtension.ChangeLastValue(actual, expectedValue);
            Assert.AreNotEqual(arrayOfNumbers[arrayOfNumbers.Length - 1], actual[actual.Length - 1]);
        }

        [TestMethod]
        public void CreatingArray_ArrayFrom10Elements_ArrayValuesWithin100()
        {
            //Arrange
            var arrayOfNumbers = ArrayExtension.CreatingArray(10);

            //Act
            var compatArray = arrayOfNumbers.Where(num => num <= 0 || num > 100).ToArray();

            //Assert
            Assert.IsTrue(0 == compatArray.Length);
        }
    }
}
