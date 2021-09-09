using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Colletions5Extension
    {
        public static int LinesToCount(string text)
        {
            var lines = text.Split('\n').Count();
            return lines;
        }

        public static int WordsToCount(string text)
        {
            string[] givenText = text.Replace("'", " ").Replace("  ", " ").Split(' ', '\n');
            int wordsToCount = 0;
            foreach (var words in givenText)
            {
                wordsToCount++;
            }
            return wordsToCount;
        }

        public static int CharactersToCount(string text)
        {
            var characters = text.Count();
            return characters;
        }
    }
}
