using CSharpWithPatrick.DayThree.OOPConceptsContinued.Day3SampleProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.Collections.KeyValuePairs_Hashtable
{
    class ExampleHashTable
    {
        static void Main()
        {
            /* Hashtables fall under a type of collections called 'KEY-VALUE PAIRS'
         * 
         * They are useful when we want to assign specific keys to specific objects
         * so that we can access these objects by calling the 'keys' directly etc
         * 
         * A way of making collections easily manageable
         * 
         * Hashtable is a non-generic version of a 'Key-Value Pair' collection
         * 
         * This means we can use any combination of datatypes to specify keys and values in
         * a hastable. e.g. the key could be an integer, and the value is a string; key could
         * be a string and value is a double etc. 
         * 
         * Any mix is allowed.
         * 
         * We create hashtables as below
         * 
         * Hashtables just like ArrayList and List also lives under the System.Collections
         * 'using' namespace in c# 
         */

            Hashtable ht = new Hashtable();
            /*note how we don't need to specify a particular datatype or even the order of entry when 
             * creating it. It defaults to the first data entered in the line being the object key  
             * and the second piece of data entered is assigned as the object value
             * 
             * Like below
             */

            ht.Add("one", 10);
            ht.Add(1, 10.5);
            ht.Add(true, "string");

            //Notice how the keys and values can be any mix of datatypes

            //Another allowed syntax for adding objects to this list is 

            ht["car"] = "4 door saloon";

            //We can add an Employee object alex to the list too

            Employee alex = new Employee("Alex Rod", 6);
            ht.Add(alex, "manager");

            //We can then manipulate the hastable like so

            ht.Remove(alex);
            Console.WriteLine(ht["one"]); //Should print the value 10

            Console.WriteLine("-----------------"); //spacer

            //To loop through the objects using the keys

            foreach (Object o in ht.Keys) //We can also use 'var' instead of object in that foreach statement
            {
                Console.WriteLine(o.ToString() + ":" + ht[o]);
            }
            /*This code above says: for each item in the ht keys list 'ht.keys'
           * Please convert the each key item "o" .ToString (for display to console)
           * Concatenate with a colon ':' and print out the values 'ht[o] assigned to that 
           * key...after the inserted colon.
           * 
           * Bit complex, but Run it and see!
           */

            //NOtice, the added Employee element alex, does not print, because it was removed above
        }
    }
}
