using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.Exceptions_TryCatch_Finally
{
    class Finally_Statement
    {
        static void Main()
        {
            /*The finally statement can be appended to the end of a try-catch sequence
             * 
             * Finally denotes a block of code that will always run regardless of whether
             * there were runtime errors or not.
             * 
             * The use of this?
             * 
             * Imagine we were running some tests that establish a database connection and 
             * posted some values to the database at start, and we want to run a block of code
             * to clear the database and close the database connection in case the tests
             * throw an exeption at runtime... We can use a FINALLY statement at the end 
             * of a try-catch for this 
             * 
             * See below
             */

            int a = 10;
            int b = 1;
            int c = 0;

            /*This code below is well written so should run with no errors. Our try-catch should
             * therefore not be executed.
             * 
             * And our code in the FINALLY section below should be executed 
             * Even though our executable code, which lives within the 'try' statement
             * was not run...
             */ 

            try
            {        
                c = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ama's error msg (Finally Statment) : " + e.Message);
            }
            finally
            {
                Console.WriteLine("Ama says: This program ran with no errors");
            }

            //Run it!
        }
    }
}
