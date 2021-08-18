using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string> colors = new List<string>
             {
                "Red",
                "Green",
                "Violet",
                "White",
                "Black"
             };
            Console.WriteLine("--------------------");
            Console.WriteLine(string.Join(",", colors));
            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i].Contains("Violet"))
                {
                    Console.WriteLine("--------------------");
                    Console.Write("Color changing to: ");
                    colors[i] = "Yellow";
                    Console.WriteLine(colors[i]);
                    Console.WriteLine("--------------------");
                }
            }
            Console.WriteLine(string.Join(",", colors));
        }
    }
}
