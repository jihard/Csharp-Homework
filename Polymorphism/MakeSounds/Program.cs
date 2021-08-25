using System;

namespace MakeSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            var soundList = new List<ISound>() { new Radio(), new Parrot(), new Firework()};
            Console.WriteLine("Choose a sound:");
            Console.WriteLine("0)Radio");
            Console.WriteLine("1)Parrot");
            Console.WriteLine("2)Firework");
            Console.WriteLine("3)To EXIT");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "0":
                    Console.Clear();
                    soundList[0].PlaySound();
                    Console.WriteLine("-------------------------");
                    return true;
                case "1":
                    Console.Clear();
                    soundList[1].PlaySound();
                    Console.WriteLine("-------------------------");
                    return true;
                case "2":
                    Console.Clear();
                    soundList[2].PlaySound();
                    Console.WriteLine("-------------------------");
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }
    }
}