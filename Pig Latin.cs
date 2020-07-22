using System;
using System.Collections;
using System.Reflection.Emit;

namespace Pig_Latin
{
    class Program
    {
        static void Main()
        {
            //Declarations
            Queue myQ = new Queue();
            char[] array = { };
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("Type a sentence to translate into Pig Latin.");
                Console.WriteLine("");
                string entry = Console.ReadLine().ToLower();

                //Catch blank entries, restart.
                if (entry.Length <= 2)
                {
                    Console.WriteLine("Not valid, please try again.");
                    Restart();
                }

                if (entry == null)
                {
                    Console.WriteLine("Not valid, please try again.");
                    Restart();
                }

                //If word starts with Vowel, than run this.
                char letter = entry[0];
                bool StartWithVowel = StartsWith(letter);
                if (StartWithVowel == true)
                {
                    Console.WriteLine($"{entry}way");
                    Restart();
                }


                //If starts with two Consanants
                bool TwoConsanants = TwoBeginWith(entry[0], entry[1]);
                if (TwoConsanants == true)
                {
                    string build = entry.Substring(2, entry.Length-2);
                    Console.WriteLine($"{build}{entry[0]}{entry[1]}ay");
                    Restart();
                }


                //If does not start with vowel
                bool LetterChecked = StartsWith(letter);
                if (LetterChecked == false)
                {
                    string build = entry.Substring(1, entry.Length-1);
                    Console.WriteLine($"{build}{entry[0]}ay");
                    Restart();
                }
                
                else
                {
                    Console.WriteLine("Something went wrong with that input");
                    Restart();
                }
            }
        }

        static bool TwoBeginWith(char vowel, char vowel2)
        {
            //If neither vowel or vowel2 contain a vowel, return true.
            if (vowel != 'a' && vowel2 != 'a' && vowel != 'e' && vowel2 != 'e' && vowel != 'i' && vowel2 != 'i' && vowel != 'o' && vowel2 != 'o' && vowel != 'u' && vowel2 != 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool StartsWith(char vowel)
        {
            //If the first character is a vowel, return true.
            if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel== 'o' || vowel == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Restart()
        {
            //Method called to restart.
            Console.WriteLine("");
            Console.WriteLine("Quit?. Y/N?");
            string y = Console.ReadLine().ToLower();
            if (y == "y")
            {
                Environment.Exit(1);
            }
            else
            {
                Console.Clear();
                Main();
            }
        }

    }
}
