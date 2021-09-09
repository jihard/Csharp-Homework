using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise5.Tests
{
    [TestClass]
    public class Colletions5Tests
    {
        [DataTestMethod]
        [DataRow("apple is red", 12)]
        [DataRow("simple as it", 12)]
        [DataRow("your \n QL one", 13)]
        [DataRow("Doit yours self !? Qxy0", 23)]
        public void CharactersToCount_FromText_ReturNumberOfCharacters(string text, int expected)
        {
            //Act
            var actual = Colletions5Extension.CharactersToCount(text);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("apple is red", 1)]
        [DataRow("Doit \n is one", 2)]
        [DataRow("simple\n self\n", 3)]
        public void LinesToCount_FromText_ReturNumberOfLines(string text, int expected)
        {
            //Act
            var actual = Colletions5Extension.LinesToCount(text);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow("apple is red", 3)]
        [DataRow("apple\n isn't blue ", 6)]
        [DataRow("this\n isn't, right ", 6)]
        public void WordsToCount_FromText_ReturNumberOfWord(string text, int expected)
        {
            //Act
            var actual = Colletions5Extension.WordsToCount(text);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
