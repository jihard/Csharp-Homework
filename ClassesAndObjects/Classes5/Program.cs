using System;

namespace Classes5
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(0, 0, 0);
            Console.WriteLine("Enter Month");
            int m = Int32.Parse(Console.ReadLine());
            date.SetMonth(m);
            Console.WriteLine("Enter Day ");
            int d = Int32.Parse(Console.ReadLine());
            date.SetDay(d);
            Console.WriteLine("Enter Year");
            int y = Int32.Parse(Console.ReadLine());
            date.SetYear(y);
            date.DisplayDate();
        }
    }
}

