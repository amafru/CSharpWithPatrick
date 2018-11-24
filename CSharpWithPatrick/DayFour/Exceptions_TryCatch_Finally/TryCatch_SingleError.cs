using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.Exceptions_TryCatch_Finally
{
    class TryCatch_SingleError
    {
        /*Try catch is useful whenever there's a block of code that we feel might fail/break
         * 
         * Use a try catch statement in this instance to print a meaningful error msg on the
         * console.
         * 
         * Can save us from trying to make sense of just a generic system msg
         * AND crucially gives us a way to troubleshoot the souce of the failure, using the
         * 'Exception e' statement which is built into 'try catch'
         *  
         * See below for implepementation
         */
        static void Main()
        {
            //    //Please uncomment this code up to 'Console.WriteLine("Spacer1--------") to start
            //    int a = 10;
            //    int b = 0;
            //    int c = 0;

            //    c = a / b;

            //    Console.WriteLine(c);
            //    /*A simple program to try divide 10 by 0. 
            //     *When we run this we'll get an 'Unhandled Exception' message because we attempted
            //     * to divide 10 by zero which is impossible. 
            //     * 
            //     * The message we get is generic. 
            //     * 
            //     * To throw a meaningful msg, we can envolope the above code in a try-catch statement
            //     * as below. (Please comment out the above code) 
            //     */
            //    Console.WriteLine("Spacer1--------");

            try
            {
                int a = 10;
                int b = 0;
                int c = 0;

                c = a / b;

                Console.WriteLine(c);
            }
            catch 
            {

                Console.WriteLine("Here's your useful error message. Error Occured :-)) ");

                //Run it!
            }

           //This class continues and is logically linked to TryCatch_Exeption_e class
        }
    }
}
