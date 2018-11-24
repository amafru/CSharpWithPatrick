using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOne.DayOneExercises
{
    class TextToLowerOrUpperCase
    {
        static void Main()
        {
            /*For a given string "Hello World" 
             * Print out the word "World" in Lower case*/

            string phrase = "Hello World";

            //We use .substring to find the xter in the 6th index position of the phrase array
            //And print the rest of the phrase from there
            //using .ToLower to convert everything to lower case as per the instructions

            Console.WriteLine(phrase.Substring(6).ToLower());
        }
    }
}
