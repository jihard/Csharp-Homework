using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            printSquare(1, 5);
        }

        public static void printSquare(int min, int max)
        {
            Console.Write("Enter Min? ");
            min = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Max? ");
            max = Int32.Parse(Console.ReadLine());
            int difference = max - min;
            for (int i = 0; i <= difference; i++)
            {
                for (int j = 0; j <= (difference); j++)
                {
                    Console.Write((j + i) % (difference + 1) + min);
                }
                Console.WriteLine("");
            }
        }
    }
}
