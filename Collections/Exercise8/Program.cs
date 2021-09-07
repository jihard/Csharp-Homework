using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory directory = new PhoneDirectory();
            Console.WriteLine();
            directory.PutNumber("Fred", "26590735");
            directory.PutNumber("Wilma", "24561238");
            directory.PutNumber("Tom", "21235462");
            Console.WriteLine("Contents are:");
            Console.WriteLine();
            Console.WriteLine("Number for Fred is " + directory.GetNumber("Fred"));
            Console.WriteLine("Number for Wilma is " + directory.GetNumber("Wilma"));
            Console.WriteLine("Number for Tom is " + directory.GetNumber("Tom"));
        }
    }
}