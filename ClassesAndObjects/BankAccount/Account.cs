using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes10
{
    class Account
    {
        private string Name;
        private decimal Balance;

        public Account(string name, decimal balance)
        {
            Name = name;
            Balance = balance; 
        }

        public void ShowUserNameAndBalance()
        {
            if (Balance > 0)
            Console.WriteLine($"{Name}{Balance}");
            else
            Console.WriteLine($"{Name}{Balance}");
        }
    }
}

