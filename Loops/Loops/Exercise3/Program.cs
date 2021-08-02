using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] emptyArr = new int[20];
            int arrylenght = emptyArr.Length;
            int index = 0;
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                int getrand = random.Next(1, 50);
                emptyArr[i] = getrand;
                Console.Write(emptyArr[i] + " ");
            }
            Console.Write("\n\n");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Input the number you want to find the index of:");
            index = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Element at index " + index + " is " + emptyArr[index]);
        }
    }
}