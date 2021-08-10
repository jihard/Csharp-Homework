using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Bartsaccounttransmission();
            Mattsaccounttransmission();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Account to Account ");
            Console.ForegroundColor = ConsoleColor.White;
            BankaccountToBankaccount();

            static void Bartsaccounttransmission()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bartos bank account at start");
                Console.ForegroundColor = ConsoleColor.White;
                var bartosbankaccount = new Account("Bartos account", 100.00);
                var bartosSwitzerlandbankAccount = new Account("Bartos bank account in Switzerland", 1000000.00);
                Console.WriteLine(bartosbankaccount);
                Console.WriteLine(bartosSwitzerlandbankAccount);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bartos account after transactions"); 
                Console.ForegroundColor = ConsoleColor.White;
                bartosbankaccount.Withdraw(20);
                bartosSwitzerlandbankAccount.Deposit(200);
                Console.WriteLine(bartosbankaccount);
                Console.WriteLine(bartosSwitzerlandbankAccount);
            }

            static void Mattsaccounttransmission()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Matts bank account");
                Console.ForegroundColor = ConsoleColor.White;
                var mattsbankaccount = new Account("Matts account", 1000);
                var mybankaccount = new Account("My account", 0);
                var money = mattsbankaccount.Withdraw(100);
                mybankaccount.Deposit(money);
                Console.WriteLine(mattsbankaccount);
                Console.WriteLine(mybankaccount);
            }

            static void BankaccountToBankaccount()
            {
                var aAccount = new Account("A", 100.00);
                var bAccount = new Account("B", 0);
                var cAccount = new Account("C", 0);
                AccountTOAccount(aAccount, bAccount, 50.0);
                AccountTOAccount(bAccount, cAccount, 25.0);
                Console.WriteLine(aAccount);
                Console.WriteLine(bAccount);
                Console.WriteLine(cAccount);
                Console.ReadKey();
            }
        }

        public static void AccountTOAccount(Account from, Account to, double howMuch)
        {
            var money = from.Withdraw(howMuch);
            to.Deposit(money);
        }    
    }
}
