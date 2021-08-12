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
        private decimal Balance;

        public Account(string name, decimal balance)
        {
            _name = name;
            Balance = balance; 
        }

        public void ShowUserNameAndBalance()
        {
            if (Balance > 0)
            {
                Console.WriteLine($"{_name}{Balance}");
            }
            else
            {
                Console.WriteLine($"{_name}{Balance}");
            }
        }
    }
}
