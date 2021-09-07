using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise12.Tests
{
    [TestClass]
    public class Exercise12tests
    {
        [TestMethod]
        public void Withdrawal_MakeWithdrawal255_AccountBalance999745Expected()
        {
            //Arrange
            Account account = new Account("John Doo", 1000000);

            //Act
            var actual = account.Withdraw(255);
            var expected = 999745;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Deposit_MakeDeposit100_AccountBalance1100Expected()
        {
            //Arrange
            Account account = new Account("John Doo", 1000);

            //Act
            var actual = account.Deposit(100);
            var expected = 1100;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Balance_AccountBalance100_AccountBalance100Expected()
        {
            //Arrange
            Account account = new Account("John Doo", 100);

            //Act
            var actual = account.Balance();
            var expected = 100;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ReviewAccountwithBalance100_Accountname100Expected()
        {
            //Arrange
            Account account = new Account("John Doo", 100);

            //Act
            var actual = account.ToString();
            var expected = "John Doo:$100";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_Minus100_Minus100Expected()
        {
            //Arrange
            Account account = new Account("John Doo", -100);

            //Act
            var actual = account.ToString();
            var expected = "John Doo:$-100";

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}