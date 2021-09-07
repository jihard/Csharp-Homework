using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise1;

namespace Exercise1.Tests
{
    [TestClass]
    public class Arithmetics1Tests
    {
        [DataTestMethod]
        [DataRow(15, 3, true)]
        [DataRow(9, 15, true)]
        [DataRow(9, 6, true)]
        [DataRow(18, -3, true)]
        [DataRow(18, 9, false)]
        public void IsCompatibleWith15_CheckingFromInput_BoolExpected(int x, int y, bool g)
        {
            //Act
            var result = Arithmetics1Extension.IsCompatibleWith15(x, y);

            //Assert
            Assert.AreEqual(g, result);
        }
    }
}
