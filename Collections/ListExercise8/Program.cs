﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise8
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
            Console.Write("List before sort: ");
            Console.WriteLine(string.Join(",", colors));
            colors.Sort();
            Console.Write("List after sort: ");
            Console.WriteLine(string.Join(",", colors));
        }
    }
}

