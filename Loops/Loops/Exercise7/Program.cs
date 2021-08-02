using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int playerPoints = 1 * 7;
            int playerPoints1 = 0;
            Console.WriteLine("Welcome to Dice game");
            Console.WriteLine("--------------------");
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                string roll;
                do
                {
                    playerRandomNum = random.Next(1, 7);
                    playerPoints++;
                    Console.WriteLine("you rolled a " + playerRandomNum);
                    if (playerRandomNum < 2)
                    {
                        Console.WriteLine("Your pointas are " + playerPoints1);
                        break;
                    }
                    Console.Write("Do you wanna roll again? (Y/N) -- ");
                    roll = Console.ReadLine();
                    if (roll.Equals("Y"))
                    {
                        continue;
                    }
                    else if (roll.Equals("N"))
                    {
                        Console.WriteLine("your pints are " + playerPoints);
                    }
                } while (roll == "Y");
                break;
            }
        }
    }
}
