using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class FoodValidator
    {
        public static void GetValidation(string type, string foodType)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(type + ": does not eat:--> " + foodType);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
