using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOneExamples
{
    class ArraysandForEachStatement
    {
        static void Main()
        {
            //Arrays are useful for holding a bunch of data

            int[] a = { 10, 20, 30, 40, 50, 60 };
            /*This could be considered the initial set of values for the array
             * Computer numbers these values as a[0] - which is 10 in this case - a[1] etc
             * Computer ALWAYS starts it counting at 0 by default, unless otherwise instructed
             * NOT at 1, as humans do. So if there are 5 pple stading, computer recognises that set of pple 
             * as 0,1,2,3,4*/
            //To print out a specific value to console...

            Console.WriteLine(a[3]); //This should print 40 when we run the program

            /*We can also add other values to the array outside the array, after the initial values 
             * Have already been declared. 
             * Like so...*/
            a[4] = 55;

            //And to print out ALL the values in an array. We have two options

            //OPT 1: The regular FOR statement that we know
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[" + i + "] = " + a[i]);
            }
            //Where a.Length means "entire length of array. 6 in this 
            //...case. When we count the value 55 we added after. Console should print all these when run.
            //Notice that the print out includes the 55 too. 

            Console.WriteLine("-----------------");//just used to separate output of the two FOR statements 


            //OPT 2: The FOREACH statement 

            foreach (int tempvar in a) /*where "tempvar" is just a temporary variable name given to the int
                *int datatype. Can be any name you want :-)*/

            {
                Console.WriteLine(tempvar);
            }

            Console.WriteLine("-----------------"); //Simply used to create a separting line

            /*To initialize an array with no values initially assigned to the spaces in the array
             * and then add values later*/

            int[] z = new int[6]; //This initializes an empty array "z" with 6 spaces in it for values

            //Then we can assign values to any of those spaces like so...
            z[0] = 10;
            z[3] = 50;

            /*Now print out the entire array and we should get these above values in spaces 0 and 3
             * And the other spaces should just be empty with a 0 in them*/

            foreach(int tempvar in z)
            {
                Console.WriteLine(tempvar);
            }
        }
    }
}
