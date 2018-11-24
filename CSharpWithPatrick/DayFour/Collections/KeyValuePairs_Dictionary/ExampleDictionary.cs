using CSharpWithPatrick.DayThree.OOPConceptsContinued.Day3SampleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.Collections.KeyValuePairs_Dictionary
{
    class ExampleDictionary
    {
        static void Main()
        {
            /* Dictionary falls under a type of collections called 'KEY-VALUE PAIRS'
         * 
         *See Hashtable class for more background on Key-Value pairs...
         * 
         * Dictionary is a generic version of a 'Key-Value Pair' collection
         * 
         * This means with Dictionary, we have to specify a specific data type to be accepted
         * as the KEY and a specific datatype to be accepted as the VALUE in the Key-Value pair
         * 
         * No random mixing of datatypes is allowed as is the case with a Hashtable.
         * 
         * We create Dictionaries as below
         * 
         * Dictionary (just like 'ArrayList', 'List' and 'Hashtable' also) 
         * lives under the System.Collections library in c# 
         * 
         */

            Dictionary<string, double> myDictionary = new Dictionary<string, double>();
            /*note how we NEED to specify the particular accepted datatypes and the order 
             * of entering them when creating this particular dictionary
             * 
             * We can then add objects to the dictionary like below
             */

            myDictionary.Add("zero", 1000.01);
            myDictionary.Add("one", 10);
            //myDictionary.Add(1, 10.5);//This is unacceptable, hence we get a squiggly under '1'
            myDictionary.Add("two", 1500.15);
            myDictionary.Add("true", 100);


            //We can then manipulate the Dictionary objects like so

            myDictionary.Remove("zero");//This will remove the value '1000.01' above 
            Console.WriteLine("-----------------"); //spacer

            //We can print out a specific object's value like so
            Console.WriteLine("Ama's specific object value for key 'one' is = " + myDictionary["one"]); //Should print the value 10
            Console.WriteLine("-----------------"); //spacer

            //To loop through the objects using the keys

            foreach (string x in myDictionary.Keys) //We can also use 'Object' or 'var' in place of 'string' in that foreach statement
            /*This code above says: for each item in the ht keys list 'ht.keys'
             * Please convert the each key item "o" .ToString (for display to console)
             * Concatenate with a colon ':' and print out the values 'ht[o] assigned to that 
             * key...after the inserted colon.
             * 
             * Bit complex, but Run it and see!
             */
            {
                Console.WriteLine("For Key {0} the value assigned is {1}", x, myDictionary[x]);
            }

             /*This code above says: for each item in the myDictionary keys list 'myDictionary.keys'
           * Please loop through and print out the statement above to console:
           * 
           * ***While looping though, do this, every key that is at run time assigned to temp variable 'x'
           * please replace the {0} location in the statement with that key... And every value that at runtime is 
           * assigned to 'myDictionary[x]' please replace the {1} location in the statement with that value.
           * 
           * Having established that rule
           * 
           * Run it! :))
           */

            /*Notice that the value for key 'zero' isn't printed cuz it was removed during 
            *list manipulation above
            */
        }
    }
}
