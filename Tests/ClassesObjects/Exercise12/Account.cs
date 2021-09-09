using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Account
    {
        private string _name;
        private double _money;
   
        public Account(string accountname, double funds)
        {
            _name = accountname;
            _money = funds;
        }

        public double Withdraw(double amount)
        {
            return _money -= amount;
        }

        public double Balance()
        {
            return _money;
        }

        public double Deposit(double amount)
        {
            return _money += amount;
        }

        public override string ToString()
        {
            return ( _name+ ":$" +_money);
        }
    }
}

