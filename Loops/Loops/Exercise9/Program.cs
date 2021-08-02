using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desired dice sum: ");
            int sum = Int32.Parse(Console.ReadLine());
            Random random = new Random();
            int dice1 = random.Next(6) + 1;
            int dice2 = random.Next(6) + 1;
            int diceSum = dice1 + dice2;
            Console.WriteLine(dice1 + " and " + dice2 + " = " + diceSum);
            while (diceSum != sum)
            {
                dice1 = random.Next(6) + 1;
                dice2 = random.Next(6) + 1;
                diceSum = dice1 + dice2;
                Console.WriteLine(dice1 + " and " + dice2 + " = " + diceSum);
            }
        }
    }
}
