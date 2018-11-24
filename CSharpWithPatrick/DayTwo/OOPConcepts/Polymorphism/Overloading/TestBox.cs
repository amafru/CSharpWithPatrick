using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.OOP_Concepts.Polymorphism
{
    class TestBox
    {
        static void Main()
        {
            Box hotbox = new Box();

            hotbox.CalculateTotalArea(5, 5); //This calls version 2 of the method (i.e 2 intergers)
            hotbox.CalculateTotalArea(5.5); //This calls ver 1
            hotbox.CalculateTotalArea(5.5, 2); //this calls ver 3

            //Run it!

        }

        
    }
}
