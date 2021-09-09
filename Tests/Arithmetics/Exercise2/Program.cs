using System;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");
            }
            else
            {
                Console.WriteLine("Entered Number is an Odd Number");

            }
            Console.WriteLine("bye!");
        }

        public class Arithmetics2Extension
        {
            private int _number;

            public Arithmetics2Extension(int number)
            {
                _number = number;
            }

            public bool IsInput_OddNumber()
            {
                return _number % 2 == 0;
            }
        }
    }
}
