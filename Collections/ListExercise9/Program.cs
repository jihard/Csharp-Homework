using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Joined colletion lists");
            Console.WriteLine("----------------------");
            List<string> firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };
            for (int i = 0; i < firstList.Count; i++)
            {
                Console.WriteLine(firstList[i]);
            }
            List<string> secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };
            for (int i = 0; i < secondList.Count; i++)
            {
                Console.WriteLine(secondList[i]);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Seperated colletion lists");
            Console.WriteLine("-------------------------");
            Console.WriteLine(string.Join(",", firstList));
            Console.WriteLine(string.Join(",", secondList));
        }
    }
}