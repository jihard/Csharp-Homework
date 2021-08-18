using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };
            if (colors.Contains("White"))
            {
                Console.WriteLine("Found the color");
            }
            else
            {
                Console.WriteLine("There is no such color");
            }
        }
    }
}
