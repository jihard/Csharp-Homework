using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, second, result, dots = "";
            int counting, periods, i;
            Console.WriteLine("Please enter word first: ");
            first = Console.ReadLine();
            Console.WriteLine("Please enter word second: ");
            second = Console.ReadLine();
            result = first + "" + second;
            counting = result.Length;
            periods = 29 - counting;
            for (i = 1; i <= periods; i++) dots += ".";
            {
                if (counting <= 29)
                {
                    dots += "";
                    Console.WriteLine(first + dots + second);
                }
            }
        }
    }
}
