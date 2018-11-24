using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.PassingArgumentsAndThisKeyword
{
    class TestBox3
    {
        static void Main()
        {
            Box3 fedex = new Box3();

            fedex.length = 20;
            fedex.width = 10;
            fedex.CalculateTotalArea(5, 3);
        }
    }
}
