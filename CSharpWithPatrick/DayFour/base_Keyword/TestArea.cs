using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.base_Keyword
{
    class TestArea
    {
        static void Main()
        {
            Square s1 = new Cube(); //We've used inheritance to advantage here, to create a reusable object of the superclass, obj 's1' to save memory
            s1.CalculateArea(5);

            Console.WriteLine("--------------------"); //spacer...

            //We can reuse the s1 object to call calculate area of a simple square like so

            s1 = new Square(); //As we've created a new Square, not a new cube, the original calculate area from Square class will be called and
            s1.CalculateArea(2); //4 should be printed to console
        }

        //Run it!
    }
}
