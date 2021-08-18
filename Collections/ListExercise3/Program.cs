using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
           Collection<string> colors = new Collection<string>();
            colors.Add("\nRed");
            colors.Add("\nGreen");
            colors.Add("\nOrange");
            colors.Add("\nWhite");
            colors.Add("\nBlack");
            colors.Insert(0, "\nBlue");
            colors.Insert(2, "\nYellow");
            Display(colors);
            static void Display(Collection<string> colorSet)
            {
                Console.WriteLine();
                foreach (string item in colorSet)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
