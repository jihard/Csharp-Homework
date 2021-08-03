using System;

namespace Exercise2
{
    class Program
    {       
        private static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sum = 0;
            var i = 0;
            var maxNumber = myArray[0];
            var minNumber = myArray[0];
            Console.WriteLine("Please enter a min number");
            minNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            maxNumber = Int32.Parse(Console.ReadLine());
            for (i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }
            }
            sum = (minNumber + maxNumber);
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
