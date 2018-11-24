using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.BoxUPSAndFEDEXExample
{
    class Box
    {
        public int length;
        public int width;

        public void CalculateTotalArea()
        {
            int totalArea = length * width;

            Console.WriteLine("Total Area = " + totalArea);
        }
    }
}
