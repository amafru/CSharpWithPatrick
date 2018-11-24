using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.BoxUPSAndFEDEXExample
{
    class TestBox
    {
        static void Main()
        {
            Box Ups, Fedex;
            Ups = new Box();
            Fedex = new Box();

            Ups.length = 10;
            Ups.width = 5;
            Ups.CalculateTotalArea();

            Fedex.length = 20;
            Fedex.width = 10;
            Fedex.CalculateTotalArea();
        }
    }
}
