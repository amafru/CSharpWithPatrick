using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOne.Examples
{
    class ExampleOneFirstPrograms
    {
        static void Main()
        {
            //My first program
            Console.WriteLine("Hello World");

            //Adding up numbers 
            int x = 10;
            int y = 3;
            int result = x + y;

            //Printing result to console 
            Console.WriteLine(result);

            //To print a more descriptive result...
            Console.WriteLine("The result is equal to " + result);

            /*We can also calculate a result based on modulus operator
             * Modulus takes the last number in the sequence e.g. 3 above and places it into the previous
             * number e.g. 10 above. The remaining value after 3 has been placed into 10 as many times as 
             * possible is the modulus value. E.g. for above 10 modulus 3 is equal to 1*/

            int result2 = x % y;
            Console.WriteLine("Modulus result is = " + result2);

            //Using placeholders to hold values 
            Console.WriteLine("Placeholder programe result is equal to {0} + {1} = {2}", x, y, (x + y));
        
        }
    }
}
