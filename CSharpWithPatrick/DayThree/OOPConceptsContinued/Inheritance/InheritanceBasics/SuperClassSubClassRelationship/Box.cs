using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Inheritance
{
    class Box
    {
        public void CalculateTotalArea(int length, int width)
        {
            int totalArea = length * width;

            Console.WriteLine("Total Area = " + totalArea);
        }
        /*We can create an object of this class from the TestBox class and call this Calculate
         * Total area method as shown...(see TestBox class)*/
    }
}
