using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.Exceptions_TryCatch_Finally
{
    class TryCatch_MultipleErrorHandling
    {
        static void Main()
        {
            /*Continuing from TryCatch_SingleError...
         * 
         * What if I'm writing a program where multiple errors are possible for different
         * methods... And I want to throw a different bespoke error message for each 
         * possible error?
         * 
         * We can use multiple 'catch'(es) in the try-catch statement. Like below
         * 
         */

            int[] d = new int[3]; //so this array can only take 3 integer variables
            /*But we're gonna try specify an a[10] value below, which of course will throw
             * an Unhandled system message, cuz the array only takes 3 variables not 10
             */

            int a = 10;
            int b = 0;
            int c = 0;

            try
            {
                d[10] = 10; //trying to add a variable in position 10. Should give us error at runtime
                c = a / b; //Should give error too. Cuz we can't divide 10 by zero

            }
            //Something like d[10] = 10 normally throws 'IndexOutOfRangeException' so we specify below what to do in IndexOutOfRangeException like so
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array can only take 3 variables : " + e.Message);
            }
            //Something like 10/0 (i.e. c = a /b) normally throws 'DivideByZeroException' so we specify below what to do in DivideByZeroException like so
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Can't divide a number" + a + "by zero : " + e.Message);
            }
            
            /* NOTE: The very first error encountered is the one who's msg will be printed 
             * to console...
             * 
             * You can comment out the first line of code above in order to force the system 
             * to encounter the 2nd error programmed, and so throw the 2nd error message.
             * 
             */

            //Run it!
        }
    }
}
