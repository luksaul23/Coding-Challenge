using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question_3
{
    class Program
    {

        /*Abbreviate
         * Builds a new string using the the format (first letter) + (count of removed letters) + (last letter)
         * Param: string word - word to be abbreviated
         * Return: abbr - the abbreviated word
         */
        static string Abbreviate( string word )
        {
            if(word.Length > 2)
            {
                var abbr = new StringBuilder();
                abbr.Append(word[0]);
                abbr.Append((word.Length - 2).ToString());
                abbr.Append(word[word.Length - 1]);

                return abbr.ToString();
            } else
            {
                Console.WriteLine("{0} was too short for the abbreviation pattern", word);
                return "Word was too short";
            }
        }

        /* Build Dictionary
         * adds the word and its abbreviation as a key-value pair to a dictionary
         * Param: List<string> list - list of words to be abbreviated
         * Param: Dictionary<string, string> dict - dictionary to store the key-value pairs
         * Return: nothing
         */
        static void BuildDictionary(List<string> list, Dictionary<string, string> dict)
        {
            foreach( var word in list)
            {
                dict.Add(word, Abbreviate(word));
            }
        }

        /* CheckForUniqueness
         * Cycles through the dictionary comparing the values to the given value to determine
         * if the value is unique
         * Param: Dictionary<string, string> dict - dictionary holding the words and the abbreviations
         * Param: string value - value that is being checked for uniqueness
         * Return: Bool
         */
        static bool CheckForUniqueness(Dictionary<string, string> dict, string value)
        {
            int count = 0;
            foreach( var def in dict )
            {
                if(def.Value == value)
                {
                    count++;
                }
            }

            // If the count is one the abbreviation is unique. If it isn't the abbreviation is not unique
            if( count == 1)
            {
                return true;
            } else
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
            /*

            * Such abbreviations are not always unique, for example:
            *   "accessibility" -> "a11y"
            *   "automatically" -> "a11y"
            * Given a dictionary (a list of words), write a function that takes a word and
            * returns true if the abbreviation of the word is unique in the dictionary.
            *
            * For example, given a dictionary with the 4 words above:
            *   "internationalization" -> true
            *   "localization" -> true
            *   "accessibility" -> false
            *   "automatically" -> false
            */

            // Initialize variables for use
            List<string> input = new List<string>();
            Dictionary<string, string> WordAbbr = new Dictionary<string, string>();

            Console.WriteLine("Enter a list of words in the form of internationalization, localization, accessibility, automatically,...");

            //read in the input and split it
            string inputString = Console.ReadLine();
            string[] words = inputString.Split(", ");

            //add words to the list
            foreach( var word in words )
            {
                input.Add(word);
            }

            //build the dictionary using the list
            BuildDictionary(input, WordAbbr);
            
            // cycle through the dictionary and determine if the key has a unique abbreviation and print them out
            foreach(var def in WordAbbr)
            {
                Console.WriteLine("\"{0}\" -> {1}", def.Key, CheckForUniqueness(WordAbbr, def.Value));
            }

            //keep the application from closing before the results are displayed
            Console.ReadLine();

        }
    }
}
