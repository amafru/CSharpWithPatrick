using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.Exceptions_TryCatch_Finally
{
    class TryCatch_Exception_e
    {
        static void Main()
        {
            //Please vist TryCatch_SingleError class as a starting point

            /*There's also something called 'Exception e' built into the try-catch statement
            * 'e' provides us with other usefuls options for troubleshooting any system exceptions 
            * such as
            * 
            * 1) Telling us the specific error message focus on from the big system message (e.Message)
            * 2) Showing us full location of the project where the error took place (e.Stacktrace)
            * 3) Telling us at which method the error occured (e.TargetSite)
            * 4) Telling us the project name in which the exception occured (e.Source)
            * 
            * See below
            */

            try
            {
                int a = 10;
                int b = 0;
                int c = 0;

                c = a / b;

                Console.WriteLine(c);
            }
            catch (Exception e)
            {

                Console.WriteLine("Ama's bespoke error message. Error Occured :-)) "); //My bespoke message
                Console.WriteLine(); //insert empty space
                Console.WriteLine("Standard system error message : " + e);
                Console.WriteLine();
                Console.WriteLine("Specific message to focus on : " + e.Message);
                Console.WriteLine();
                Console.WriteLine("Full location of where error occured : " + e.StackTrace);
                Console.WriteLine();
                Console.WriteLine("Method at which the error occured is : " + e.TargetSite);
                Console.WriteLine();
                Console.WriteLine("Project name in which the error occured: " + e.Source);

                //Run it!

                /*Very useful information if we want to send off detailed error messages about
                 * failures e.g. to a team of developers, third party vendors etc.
                 */ 
            }
        }
    }
}
