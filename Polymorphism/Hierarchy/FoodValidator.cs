using System;

namespace Hierarchy
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