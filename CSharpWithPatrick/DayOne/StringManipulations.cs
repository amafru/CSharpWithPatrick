using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOneExamples
{
    class StringManipulations
    {
        static void Main()
        {
            string name = "David Beckham"; //this is stored in the system as an array of characters by default

            //Print out "Hello David Beckham"
            Console.WriteLine("Hello " + name);

            //Print name and Convert all characters to uppercase
            Console.WriteLine(name.ToUpper());

            //Print from the second character
            Console.WriteLine(name.Substring(2));

            //Print from the fourth character and up to 5 characters after that fourth character
            Console.WriteLine(name.Substring(4, 5));

            //Print index position of a particular character in the sequence e.g. index of v
            Console.WriteLine(name.IndexOf("v"));

            //We can also find what's in position 1 by querying a[1].
            Console.WriteLine(name[0]);

            Console.WriteLine("-------------");

            //We can also do a string array and manipulate it in same was as an integer array....

            string[] numbers = { "one", "two", "three" };

            foreach(string tempvar in numbers)
            {
                Console.WriteLine(tempvar);
            }

            Console.WriteLine("-------------");

            //Using CONVERT class to convert e.g. as string value to integer to manipulation etc

            string age = "32"; //We can e.g. divide or multiply this now as the computer sees it as a string

            int halfAge = Convert.ToInt32(age);
            //We can now divide that 32 by 2 etc
            Console.WriteLine(halfAge / 2);

            Console.WriteLine("-------------");

            /*We can also convert e.g a salary amount into a Double datatype for manipulation e.g. to work
             * out a 20% tax deduction from it*/

            string salary = "20000.30";

            double taxPayable = (Convert.ToDouble(salary) * 0.20);
            Console.WriteLine("Tax due is £" + taxPayable); //Should be 4000.06

        }
    }
}
