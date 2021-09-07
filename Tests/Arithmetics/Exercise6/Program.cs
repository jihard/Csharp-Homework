using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 34; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("CozaLoza ");
                }

                if (i % 21 == 0)
                {
                    Console.Write("CozaWoza ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if (i % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
