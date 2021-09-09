using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = (".. / .. / lear.txt");
            int chartercounter = 0;
            string[] Text = File.ReadAllLines(path);
            for (int i = 0; i < Text.Count(); i++)
            {
                chartercounter += Text[i].Length;
            }
            Console.WriteLine("\nLines: " + Text.Length + "\nCharters: " + chartercounter);
            string Wordcounter = File.ReadAllText(path);
            string[] textarray = Wordcounter.Split(' ', '\'', '\r', '\n');
            List<string> wordslist = new List<string>(textarray);
            wordslist.RemoveAll(item => item == "");
            Console.WriteLine("Words: " + wordslist.Count);
        }
    }
}
