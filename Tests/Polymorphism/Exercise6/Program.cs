using System;
using System.Collections.Generic;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wellcome to animal farm SILENT HILL.");
            Console.WriteLine("\n");
            Console.WriteLine("Read before you start");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter information for animals - to fill in your farm. ");
            Console.WriteLine("For mammaltype animals(Dog,Horse)-animaltype, name, weight, living region.");
            Console.WriteLine("Example: Dog Bingo 2,4 Home.");
            Console.WriteLine("For felinetype animals(Cat,Tiger)-animaltype, name, living region, weight, breed.");
            Console.WriteLine("Example: Cat Tom 1,4 Home bengal.");
            Console.WriteLine("After you provided each animal with information - PRESS ENTER - to see animal sound.");
            Console.WriteLine("In next line give type of food with number of pieces....animal weight will increse as you feed them - (Example: Vegetable 1 or Meat 2) - depending of animaltype.");
            Console.WriteLine("After you finish to fill animals to farm - Enter End - to print all your farm residents.");

            List<Animal> animals = new List<Animal>();
            string userPromt;
            Console.WriteLine("-------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEnter animal information:");
            while ((userPromt = Console.ReadLine()) != "End")
            {
                Animal animal = AnimalStorage.GetAnimal(userPromt.Split(' ', StringSplitOptions.RemoveEmptyEntries));
                animals.Add(animal);
                Console.Write("\nAnimal sound -->");
                Console.WriteLine(animal.MakeSound());
                Console.WriteLine("\nEnter type of food and number of pieces for your animal to be given:");
                Food food = FoodStorage.GetFood(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
                animal.Eat(food);
                Console.WriteLine("\nInput (End) to print all your animal information or continue to input next animal:");
            }
            PrintInfo(animals);
        }

        private static void PrintInfo(IEnumerable<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(animal);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
