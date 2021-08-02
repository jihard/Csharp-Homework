using System;

namespace Exercise2
{
    class Program
    {
        static int power(int i, int n)
        {
            if (n == 0)
                return 1;
            else if (n % 2 == 0)
                return power(i, n / 2) * power(i, n / 2);
            else
                return i * power(i, n / 2) * power(i, n / 2);
        }

        public static void Main(string[] args)
        {
            int i;
            int n;
            Console.WriteLine("Input number to power : ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Result = " + power(i, n));
        }
    }
}
