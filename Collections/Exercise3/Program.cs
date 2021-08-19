using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySet = new HashSet<string>();
            var name = string.Empty;
            do
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                mySet.Add(name);
            }
            while (name != string.Empty);
            Console.Write("Uniqe names are: ");
            foreach (var item in mySet)
            {
                Console.Write(" " + item);
            }
            Console.ReadKey();
        }
    }
}
