using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Inheritance
{
    class BigBox : Box
    {
        public void CalculateVolume(int length, int width, int height)
        {
            int volume = length * width * height;

            Console.WriteLine("Total Area = " + volume);
        }

        /*TestBox Class will now have access to both the 'CalculateTotalArea' method from Box class
         * And the 'CalculateVolume' method from BigBox class, as a result of inheritance
         * as implemented above*/
    }
}
