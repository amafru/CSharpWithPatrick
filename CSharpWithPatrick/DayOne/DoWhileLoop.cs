using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOneExamples
{
    class DoWhileLoop
    {
        static void Main()
        {
            int x = -10;

            do
            {
                Console.WriteLine("x = " + x);
                x++;
            } while (x <= 0);
        }

        /*DO WHILE guarantees that the line of code will run AT LEAST ONCE
         * is useful when we want to run a line of code at least once
         * Then check for a condition and if the condition is true, run the code again
         *etc... until the condition becomes false, then the loop cycle ends*/
    }
}
