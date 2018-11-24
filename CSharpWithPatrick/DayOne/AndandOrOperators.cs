using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOneExamples
{
    class AndandOrOperators
    {
        static void Main()
        {
            //The And symbol is represented as &
            //The Or symbol is |
            /*Short And is && (means if the first condition in that line is false, the computer shouldn't 
            *bother checking the second condition e.g. cuz for x>-0 && y>=0, BOTH conditions MUST be true
            * before console can print out the result anyway. So no need checking second one if first one 
            * is false. Saves computer processing resources and is just good practice*/
            //Short Or Symbol is ||. Same explanation as above

            int x = 10;
            int y = -10;

            if (x >= 0 && y >= 0)
            {
                Console.WriteLine("Both numbers are negative");
            }
            else if( x>= 0 || y >= 0)
            {
                Console.WriteLine("At least one number is positive");
            }
            else
            {
                Console.WriteLine("Both numbers are positive");
            }
        }
    }
}
