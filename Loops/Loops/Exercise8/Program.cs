using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Input size of pyramid: ");
            x = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= (x - i); j++)
                    Console.Write("////");
                for (int t = 1; t < i * 1; t++)
                    Console.Write("********");
                for (int j = 1; j <= (x - i); j++)
                    Console.Write("\\\\\\\\");
                Console.WriteLine();
            }
        }
    }
}
