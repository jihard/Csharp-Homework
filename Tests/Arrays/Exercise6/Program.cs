using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[arr1.Length];
            Random random = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(1, 100);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            var baseArr = ArrayExtension.CreatingArray(10);
            var arrCopy = ArrayExtension.CopyOriginalArray(baseArr);
            ArrayExtension.ChangeLastValue(arrCopy, -7);
            Console.WriteLine("===================");
            arr1[9] = -7;
            Console.WriteLine("       new array");
            Console.WriteLine("===================");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("       Old array");
            Console.WriteLine("===================");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
