using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: ");
            int y = int.Parse(Console.ReadLine());
            bool test = x == 15 || y == 15 || x + y == 15 || x - y == 15;
            Console.WriteLine($"Result: {test}");
        }
    }
}
