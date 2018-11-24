using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOneExamples
{
    class WhileLoop
    {
        static void Main()
        {
            int x = 10;

            while (x >= 0)
            {
                Console.WriteLine("x = " + x);
                x--;
            }        
        }

        /*WhILE loop is useful when we want to check for a condition first, then execute the line of 
         * code if the condition is true (not execute even once if it isn't true)
         * and repeat this process until the condition is false and the loop cycle ends*/ 
    }
}
