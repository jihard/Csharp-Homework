using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                choice = GetMenu();

                if (choice == 1)
                {
                    CalculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    CalculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    CalculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Thanks for calculating!");
                    break;
                }

            } while (choice != 4);
        }

        public static int GetMenu()
        {
            int userChoice;

            // Display the menu.
            Console.WriteLine("=======================================");
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.Write("Enter your choice (1-4) : ");

            // keyboard input
            var keyboard = Console.ReadKey();

            // get input from user
            int.TryParse(keyboard.KeyChar.ToString(), out userChoice);

            // validate input
            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Please enter a valid range: 1, 2, 3, or 4: ");
                keyboard = Console.ReadKey();
                userChoice = keyboard.KeyChar;
                int.TryParse(keyboard.KeyChar.ToString(), out userChoice);
            }
            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            double _radius;
            double PI = 3.14;

            // Get input from user
            Console.Write("\n\n");
            Console.WriteLine("====================================");
            Console.WriteLine("CIRCLE");
            Console.WriteLine("Input the radius of the circle : ");
            _radius = Convert.ToDouble(Console.ReadLine());

            // Display output
            Console.WriteLine("The circle's area is: "
            + Geometry.AreaOfCircle(_radius, PI));
            Console.WriteLine("Press ENTER to continue");
        }

        public static void CalculateRectangleArea()
        {
            double _length;
            double _width;
            Console.Write("\n\n");
            Console.WriteLine("====================================");
            Console.WriteLine("RECTANGLE");
            Console.WriteLine("Enter length of rectangle : ");
            _length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle : ");
            _width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The rectangle's area is "
            + Geometry.AreaOfRectangle(_length, _width));
            Console.WriteLine("Press ENTER to continue");
        }

        public static void CalculateTriangleArea()
        {
            double _ground;
            double _height;
            Console.Write("\n\n");
            Console.WriteLine("====================================");
            Console.WriteLine("TRIANGLE");
            Console.WriteLine("Enter length of the triangle's base?  ");
            _ground = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter triangle's height?  ");
            _height = double.Parse(Console.ReadLine());
            Console.WriteLine("The triangle's area is "
            + Geometry.AreaOfTriangle(_ground, _height));
            Console.WriteLine("Press ENTER to continue");
        }
    }
}
