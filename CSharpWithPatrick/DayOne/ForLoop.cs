using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOneExamples
{
    class ForLoop
    {
        static void Main()
        {
            /* The structure of a FOR loop:
             * part one: int i = 0, defines the initial value of our equation 
             * part 2: i < 0, defines the condition that'll be used to run the loop
             * part 3: i++ (which can also be i--) means "i plus 1" or i minus 1" and is used to check
             * the parameters specified in the 2nd part of the statement and then generate the relevant 
             * results*/
             
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
