using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    public class Arithmetics8Extensions
    {
        public static string Salary(int workingHours, double basepay)
        {
            double overtimeBasepay = 1.5 * basepay;
            double baseSalary = workingHours > 40 ? 40 * basepay : workingHours * basepay;
            double overtimeTotalPay = (workingHours - 40) * overtimeBasepay;
            string maxHours = "60";

            if (basepay < 8)
            {
                return $"Hourly rate is ${basepay:F} Its not acceptable!";
            }

            if (workingHours > 60)
            {
                return $"Working hours must not overcome {maxHours}";
            }

            if (workingHours > 40 && workingHours <= 60) return $"Salary is ${(baseSalary + overtimeTotalPay):F}.";
            {
                return $"Salary is ${baseSalary:F}.";
            }
        }
    }
}
