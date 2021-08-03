using System;

namespace Exercise6
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myIntArray = new int[10];
            int[] b = new int[myIntArray.Length];
            Random r = new Random();
            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = r.Next(1, 100);
            }
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = myIntArray[i];
            }
            Console.WriteLine("===================");
            myIntArray[9] = -7;
            Console.WriteLine("       new array");
            Console.WriteLine("===================");
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine(myIntArray[i]);
            }
            Console.WriteLine("       Old array");
            Console.WriteLine("===================");
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }
    }
}
