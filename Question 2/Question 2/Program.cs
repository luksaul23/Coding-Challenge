using System;
using System.Linq;
using System.Text;

namespace Question_2
{
    class Program
    {
        /*Abbreviate
         * Builds a new string using the the format (first letter) + (count of removed letters) + (last letter)
         * Param: string word - word to be abbreviated
         * Return: abbr - the abbreviated word
         */
        static string Abbreviate(string word)
        {
            if (word.Length > 2)
            {
                var abbr = new StringBuilder();
                abbr.Append(word[0]);
                abbr.Append((word.Length - 2).ToString());
                abbr.Append(word[word.Length - 1]);

                return abbr.ToString();
            }
            else
            {
                return "Word was too short";
            }
        }

        static void Main(string[] args)
        {
            /*
            * Consider the following style of abbreviation:
            *   (first letter) + (count of removed letters) + (last letter)
            * For example:
            *   "internationalization" -> "i18n"
            *   "localization" -> "l10n"
            * Write a function that given a word returns its abbreviation.
            */

            Console.WriteLine("Please enter a word");

            //Read in the input
            string input = Console.ReadLine();

            //Abbreviate the word
            string abbr = Abbreviate(input);

            Console.WriteLine("Abbreviation: {0}", abbr);

            //keep the application from closing before the result is displayed
            Console.ReadLine();
        }
    }
}
