using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Inheritance
{
    class TestBox
    {
        static void Main()
        {
            Box fedex = new Box();
            fedex.CalculateTotalArea(5, 4);

            /* Now what if for some reason we can't modify the Box class cuz e.g. 
             * We're forbidden from modifying the Box class or something...
             * And we don't just want to calculate the total area, we also want to calculate volume
             * We can work around this by creating a new class called 'BigBox' and define the
             * ...CalculateVolume method there
             * 
             * See BigBox class for implementation*/

            BigBox fedex1 = new BigBox();
            fedex1.CalculateTotalArea(5,4);
            fedex1.CalculateVolume(5, 5, 5);

            /*Notice that when we call the object of BigBox 'fedex1' we get access to both the methods 
             * from the Box class and from the BigBox class.
             * Whereas when we call the 'fedex' class, we don't get access to the CalculateVolume*/

        }

    }
}
