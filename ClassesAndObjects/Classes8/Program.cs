using NPOI.SS.Util;
using System;

namespace Classes8
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthsPassed = 0;
            Console.Write("How much money is in the account?: ");
            SavingsAccount demoAccount = new SavingsAccount(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Enter the annual interest rate: ");
            demoAccount.SetAnnualInterestRate(Convert.ToDouble(Console.ReadLine()));
            Console.Write("How long has the account been opened? ");
            monthsPassed = Int32.Parse(Console.ReadLine());
            for (int count = 1; count <= monthsPassed; count++)
            {
                Console.WriteLine("\n-----MONTH " + count + "-----");
                Console.Write("Enter amount deposited: ");
                demoAccount.Deposit(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Enter amount withdrawn: ");
                demoAccount.Withdraw(Convert.ToDouble(Console.ReadLine()));
                demoAccount.AddMonthlyInterest();
            }
            DecimalFormat dollar = new DecimalFormat("#,##,#0.00");
            Console.WriteLine("Total deposited: $" + dollar.Format(demoAccount.GetAccumulativeDeposits()));
            Console.WriteLine("Total withdrawn: $" + dollar.Format(demoAccount.GetAccumulativeWithdrawals()));
            Console.WriteLine("Interest earned: $" + dollar.Format(demoAccount.GetAccumulativeInterest()));
            Console.WriteLine("Ending balance: $" + dollar.Format(demoAccount.GetBalance()));
        }
    }
}
