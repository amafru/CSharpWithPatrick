using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOne.DayOneExercises
{
    class ConvertStringArrayToIntAndSumming
    {
        static void Main()
        {
            /*Given a string array
             * Convert these values to doubles and sum up the total of the values in the array*/
            

            string[] a = { "3.45", "3.87", "87.98", "56.7" };

            //First we create an empty variable to use for our total amount. In this case "total"

            double total = 0.0; //the 0.0 is just a placeholder. 
            //Same thing writing it as 'double total;'

             /* Then we need to loop through the array and convert each "string value" to a Double 
              *datatype and then 
             * For this, we'll use the FOREACH statement*/

            foreach (string tempvar in a)
            {
                total = total + Convert.ToDouble(tempvar);  
            }
            Console.WriteLine(" Total = " + total);
        }
    }
}
