using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes10
{
    class Account
    {
        private string _name;
        private decimal _balance;

        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance; 
        }

        public void ShowUserNameAndBalance()
        {
            if (_balance > 0)
            {
                Console.WriteLine($"{_name}{_balance}");
            }
            else
            {
                Console.WriteLine($"{_name}{_balance}");
            }
        }
    }
}
