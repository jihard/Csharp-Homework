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
            Barts_account_transmission();
            Matts_account_transmission();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Account to Account ");
            Console.ForegroundColor = ConsoleColor.White;
            Bankaccount_To_Bankaccount();

            static void Barts_account_transmission()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bartos bank account at start");
                Console.ForegroundColor = ConsoleColor.White;
                var bartos_bank_account = new Account("Bartos account", 100.00);
                var bartos_Switzerland_bankAccount = new Account("Bartos bank account in Switzerland", 1000000.00);
                Console.WriteLine(bartos_bank_account);
                Console.WriteLine(bartos_Switzerland_bankAccount);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bartos account after transactions"); 
                Console.ForegroundColor = ConsoleColor.White;
                bartos_bank_account.Withdraw(20);
                bartos_Switzerland_bankAccount.Deposit(200);
                Console.WriteLine(bartos_bank_account);
                Console.WriteLine(bartos_Switzerland_bankAccount);
            }

            static void Matts_account_transmission()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Matts bank account");
                Console.ForegroundColor = ConsoleColor.White;
                var matts_bank_account = new Account("Matts account", 1000);
                var my_bank_account = new Account("My account", 0);
                var money = matts_bank_account.Withdraw(100);
                my_bank_account.Deposit(money);
                Console.WriteLine(matts_bank_account);
                Console.WriteLine(my_bank_account);
            }

            static void Bankaccount_To_Bankaccount()
            {
                var aAccount = new Account("A", 100.00);
                var bAccount = new Account("B", 0);
                var cAccount = new Account("C", 0);
                Account_TO_Account(aAccount, bAccount, 50.0);
                Account_TO_Account(bAccount, cAccount, 25.0);
                Console.WriteLine(aAccount);
                Console.WriteLine(bAccount);
                Console.WriteLine(cAccount);
                Console.ReadKey();
            }
        }

        public static void Account_TO_Account(Account from, Account to, double howMuch)
        {
            var money = from.Withdraw(howMuch);
            to.Deposit(money);
        }    
    }
}

