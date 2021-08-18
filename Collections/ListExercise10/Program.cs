using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");
            Console.WriteLine("Original array list: ");
            foreach (string item in colors)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("New array list: ");
            colors.Clear();
        }
    }
}

