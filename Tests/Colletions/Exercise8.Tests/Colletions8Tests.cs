using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise8.Tests
{
    [TestClass]
    public class Colletions8Tests
    {
        private PhoneDirectory _testPhoneBook;

        public Colletions8Tests()
        {
            _testPhoneBook = new PhoneDirectory();
        }

        [TestMethod]
        public void GetNumber_ReviewContactList_ReturnNumberbyName()
        {
            // Arrage
            var name = "contactName";

            // Act
            var actual = _testPhoneBook.GetNumber(name);

            // Assert
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void PutNumber_AddWithoutName_nameOrNumberIsEmptyExpected()
        {
            // Arrange
            _testPhoneBook = new PhoneDirectory();
            var expected = " name or number is empty ";

            // Act
            var actual = _testPhoneBook.PutNumber("", "22334422");

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
