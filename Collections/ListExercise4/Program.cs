using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colors = new List<string>();
            colors.Add("\nRed");
            colors.Add("\nGreen");
            colors.Add("\nOrange");
            colors.Add("\nWhite");
            colors.Add("\nBlack");
            colors.AddRange(new string[] { "\nGray", "\nPurple" }); 
            foreach (string name in colors)
            {
                Console.Write($"{name}, ");
            }
        }
    }
}  
   
