using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise8.Tests
{
    [TestClass]
    public class Arithmetics8Tests
    {
        [DataTestMethod]
        [DataRow(10, 7, "Hourly rate is $7,00 Its not acceptable!")]
        [DataRow(60, 5, "Hourly rate is $5,00 Its not acceptable!")]
        [DataRow(22, 7.5, "Hourly rate is $7,50 Its not acceptable!")]
        public void Salary_BasepayIsUnder8_ItWontCountSalary(int hours, double basepay, string expected)
        {
            //Act
            var actual = Arithmetics8Extensions.Salary(hours, basepay);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(62, 8.5, "Working hours must not overcome 60")]
        [DataRow(70, 8, "Working hours must not overcome 60")]
        [DataRow(80, 11, "Working hours must not overcome 60")]
        public void Salary_JobHoursMustNotOvercome60_ItWontCountSalary(int hours, double basepay, string expected)
        {
            //Act
            var actual = Arithmetics8Extensions.Salary(hours, basepay);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(48, 8.5, "Salary is $442,00.")]
        [DataRow(58, 8, "Salary is $536,00.")]
        [DataRow(20, 9.5, "Salary is $190,00.")]
        [DataRow(60, 11, "Salary is $770,00.")]
        public void Salary_CountsSalaryforeachWorkScenario_ReturnsCorrectSalary(int hours, double basepay, string expected)
        {
            //Act
            var actual = Arithmetics8Extensions.Salary(hours, basepay);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
