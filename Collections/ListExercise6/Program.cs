using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();
            List<string> colors1 = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");
            Console.WriteLine(string.Join(",", colors));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" After removing third element from the list: ");
            Console.WriteLine("-----------------------------------------------");
            colors1.Add("Red");
            colors1.Add("Green");
            colors1.Remove("Orange");
            colors1.Add("White");
            colors1.Add("Black");
            Console.WriteLine(string.Join(",", colors1));
        }
    }
}

