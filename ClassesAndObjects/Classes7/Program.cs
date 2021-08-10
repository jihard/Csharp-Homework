using System;

namespace Classes7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog max = new Dog("Max", "male", "Lady", "Rocky");
            Dog rocky = new Dog("Rocky", "male", "Molly", "Sam");
            Dog sparky = new Dog("Sparky", "male", null, null);
            Dog buster = new Dog("Buster", "male", "Lady", "Sparky");
            Dog sam = new Dog("Sam", "male", null, null);
            Dog lady = new Dog("Lady", "female", null, null);
            Dog molly = new Dog("Molly", "female", null, null);
            Dog coco = new Dog("Coco", "female", "Molly", "Buster");
            coco.FathersName();
            sparky.FathersName();
            Console.WriteLine("\n");
            rocky.HasSameMothersAS(coco);
        }
    }
}
