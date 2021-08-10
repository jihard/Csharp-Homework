using System;
using System.Drawing;

namespace Classes9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            Console.WriteLine("Before swap");
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
            SwapPoints(ref p1, ref p2);
            Console.WriteLine("After swap");
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
        }

        public static void SwapPoints(ref Point p1, ref Point p2)
        {
            p1.X ^= p2.X;
            p2.X ^= p1.X;
            p1.X ^= p2.X;
            p1.Y ^= p2.Y;
            p2.Y ^= p1.Y;
            p1.Y ^= p2.Y;
        }
    }
}
