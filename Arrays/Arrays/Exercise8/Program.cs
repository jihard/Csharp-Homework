using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Sveicināti vārdu spēlē!  --  Jums ir 5 mēģinājumi uzminēt vārdu");
            string textt = "";
            Random random = new Random((int)DateTime.Now.Ticks);
            string[] wordsample = { "alus", "zeme", "saule", "akmens", "zobens", "koks" };
            string wordToGuess = wordsample[random.Next(0, wordsample.Length)];
            string wordToGuessUppercase = wordToGuess.ToUpper();
            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();
            int lives = 4;
            bool won = false;
            int lettersRevealed = 0;
            string input;
            char guess;
            string quite;
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                displayToPlayer.Append('_');
            }
            while (!won && lives > -1)
            {
                Console.WriteLine("=================================================");
                Console.Write("Ievadi burtu: ");
                input = Console.ReadLine().ToUpper();
                while (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Neievadiji nevienu burtu");
                    Console.Write("Ievadi burtu: ");
                    input = Console.ReadLine();
                }
                guess = input[0];
                if (correctGuesses.Contains(guess))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\n");
                    Console.WriteLine("Jau ir ievadīts '{0}', un tas bija pareizs!", guess);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\n");
                    Console.WriteLine("Nepareizie burti:" + textt);
                    Console.Write("\n\n");
                    Console.WriteLine("Vārds: " + displayToPlayer.ToString());
                    continue;
                }
                else if (incorrectGuesses.Contains(guess))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\n");
                    Console.WriteLine("Jau tika ievadīts '{0}', Tāda burta nav..ievadiet citu!", guess);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\n");
                    Console.WriteLine("Nepareizie burti:" + textt);
                    Console.Write("\n\n");
                    Console.WriteLine("Vārds: " + displayToPlayer.ToString());
                    continue;
                }
                if (wordToGuessUppercase.Contains(guess))
                {
                    correctGuesses.Add(guess);
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuessUppercase[i] == guess)
                        {
                            displayToPlayer[i] = wordToGuess[i];
                            lettersRevealed++;
                        }
                        if (lettersRevealed == wordToGuess.Length)
                        {
                            won = true;
                            break;
                        }
                    }
                }
                else
                {
                    incorrectGuesses.Add(guess);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\n");
                    Console.WriteLine("Šajā vārdā nav burta '{0}'", guess);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\n");
                    Console.WriteLine("Vārds: " + displayToPlayer.ToString());
                    Console.Write("\n\n");
                    Console.WriteLine("Atlikuši {0} mēģinājumi! ", lives--);
                    Console.Write("Ievadi nepareizo burtu atkārtoti lai to reģistrētu :");
                    textt = textt + " " + Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nepareizie burti:" + textt);
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Console.WriteLine("Nepareizie burti:" + textt);
                Console.WriteLine("Vārds: " + displayToPlayer.ToString());
            }
            if (won)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vārds ir uzminēts!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("===========================================");
                Console.WriteLine("Vēlies spēlēt vēlreiz? (ja/ne)");
                quite = Console.ReadLine();
                Console.Clear();
                do
                {
                    if (quite.Equals("ja"))
                    {
                        Main();
                    }
                    else if (quite.Equals("ne"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Paldies par spēli");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }   while (quite == "ja");
            }
            else
            {
                Console.Write("\n\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Neuzminēji vārdu! Tas bija '{0}'", wordToGuess);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("===========================================");
                Console.WriteLine("Vēlies spēlēt vēlreiz? (ja/ne)");
                quite = Console.ReadLine();
                Console.Clear();
                do
                {
                    if (quite.Equals("ja"))
                    {
                        Main();
                    }
                    else if (quite.Equals("ne"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Paldies par spēli");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                }   while (quite == "ja");
            }
        }
    }
}
