using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise6
{
    public class Program
    {
        private const string _path = ".. / .. / flights.txt";

        private static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            string text = File.ReadAllText(_path);
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Display list of the cities press 1");
            Console.WriteLine("2) To select a city from which you would like to start press 2");
            Console.WriteLine("3) To exit program press #");
            Console.Write("\r\nSelect an option: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine($"\n{text}\n");
                    return true;

                case "2":
                    Tripmaker();
                    return true;

                case "#":
                    return false;

                default:
                    return true;
            }
        }

        public static void Tripmaker()
        {
            string[] lines = File.ReadAllLines(_path);
            string text = File.ReadAllText(_path);
            List<string> citysList = new List<string>();
            List<string> travelboard = new List<string>();
            List<string> flightboard = new List<string>();
            Console.Clear();
            Console.WriteLine("Welcome to Airport flights reservations");
            Console.WriteLine("****************************************");
            Console.WriteLine("Departures      Destination");
            Console.WriteLine("   |               |       ");
            Console.WriteLine("   V               V      ");
            Console.WriteLine($"\n{text}\n");
            Console.WriteLine("Lets plan your trip!");
            Console.Write("From where you want to start?: ");
            for (int i = 0; i < lines.Length; i++)
            {
                string item = lines[i];
                var list = item.Split('-', '>');
                flightboard.Add(item);
                citysList.Add(list[0].Trim());
                citysList.Add(list[1].Trim());
            }

            var inputStart = Console.ReadLine();
            if (citysList.Contains(inputStart) == true)
            {
                travelboard.Add(inputStart);
            }

            while (true)
            {
                Console.Write("\nYor starting city is - " + inputStart + " - where you want to go next: ");
                var inputCity = Console.ReadLine();
                Console.Write("Now you will arrive to - " + inputCity);
                if (flightboard.Contains($"{string.Join("", travelboard[travelboard.Count() - 1])} -> {string.Join("", inputCity)}") == true)
                {
                    travelboard.Add(inputCity);
                }
                else
                {
                    Console.WriteLine("\nWrong destination city ");
                    Console.WriteLine("----------------------------");
                    break;
                }

                if (travelboard[0] == travelboard[travelboard.Count() - 1] == true)
                {
                    Console.WriteLine("\nThe flights are booked!");
                    Console.WriteLine("Travel plan " + string.Join(" -> ", travelboard));
                    break;
                }
            }
        }
    }
}
