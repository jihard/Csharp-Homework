using System;
using System.Linq;

namespace Exercise6
{
    public class ArrayExtension
    {
        public static int[] CreatingArray(int arrLength)
        {
            Random random = new Random();
            var arrayOfNumbers = new int[arrLength].Select(num => random.Next(1, 100)).ToArray();
            return arrayOfNumbers;
        }

        public static int[] CopyOriginalArray(int[] arrayOfNumbers)
        {
            var copiedArr = new int[arrayOfNumbers.Length];
            Array.Copy(arrayOfNumbers, copiedArr, arrayOfNumbers.Length);
            return copiedArr;
        }

        public static int[] ChangeLastValue(int[] arrayOfNumbers, int value)
        {
            arrayOfNumbers[9]  = value;
            return arrayOfNumbers;
        }
    }
}
