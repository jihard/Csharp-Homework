using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account benben = new Account("Benson $", decimal.Round((decimal)-17.50m, 2, MidpointRounding.AwayFromZero)); 
            Account butkus = new Account("Ivo $", decimal.Round((decimal)17.25, 2, MidpointRounding.AwayFromZero));
            benben.ShowUserNameAndBalance();
            butkus.ShowUserNameAndBalance();
        }
    }
}
