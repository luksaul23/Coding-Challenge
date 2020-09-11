using System;
using System.Collections.Generic;

namespace Question1
{
    class Program
    {
        /* Swap
         * Takes in a list and the indexes of the values being swapped
         * Param: int x - index of the first value
         * Param: int y - index of the second value
         * Param: List<int> list - the list of integer values
         * Return: void
         */
        static void Swap( int x, int y, List<int> list)
        {
            int temp = list[x];
            list[x] = list[y];
            list[y] = temp;
        }

        /* Shufflelist
         * Takes in a list and shuffles the order of the values in it
         * Param: List<int> list - list of integer values
         * Param: int n - length of the list
         * Return: list - the shuffled version of the list
         */
        static List<int> Shufflelist( List<int> list, int n)
        {
            if( n > 0 )
            {
                Random random = new Random();
                int swapIndex = random.Next(0, n - 1);
                Swap(n, swapIndex, list);
                n--;
                Shufflelist(list, n);
            } else
            {
                return list;
            }

            return list;
        }

        /* Print
         * Takes in a list and prints it out to the console
         * Params: List<int> list - list of integers
         * Return: void
         */
        static void Print( List<int> list )
        {
            for( int x = 0; x < list.Count; x++)
            {
                Console.Write("{0} ", list[x]);
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            /* Question 1
             * Small application
             * Given a fully sorted list (ascending or descending),
             * write a method to scramble the values
             * e.g. (7,13,13,18,29,33)
             * write the code with use-ability, debugging, and testing in mind
             */

            Console.WriteLine("Please enter a sorted list of values e.g. (7,13,13,18,29,33) or (7 13 13 18 29 33)");

            // Initialize list for input
            List<int> list = new List<int>();

            // Create an list of delimiters for the read in
            char[] delims = { ' ', ',' };

            string temp = Console.ReadLine();
            string[] nums = temp.Split(delims);

            foreach( var num in nums )
            {
                // Check to see if the input is an integer if not, ignore it
                if(!int.TryParse(num, out int result)) {
                    Console.WriteLine("{0} was not an integer so it was ignored.", num);
                    continue;
                }
                list.Add(Convert.ToInt32(num));
            }
           
            // Print the original console for testing purposes
            Console.WriteLine("Original list:");
            Print(list);

            // Shuffle the list
            int n = list.Count - 1;
            Shufflelist(list, n);

            // Print the shuffled list
            Console.WriteLine("Shuffled list:");
            Print(list);

            //keep the application from closing
            Console.ReadLine();
        }
    }
}
