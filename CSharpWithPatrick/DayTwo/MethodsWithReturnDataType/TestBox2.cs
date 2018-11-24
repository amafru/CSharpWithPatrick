using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.MethodsWithReturnDataType
{
    class TestBox2
    {
        static void Main()
        {
            Box2 Ups, Fedex;
            Ups = new Box2();
            Fedex = new Box2();

            Ups.length = 10;
            Ups.width = 5;
            //Now if I say
            int total = Ups.CalculateTotalArea(); //result should be 50
            /*When UPS calls CalculateTotal.... the result will be stored(returned) and retained
             * within that variable 'total'*/

            Fedex.length = 20;
            Fedex.width = 10;

            //So if I now call
            total += Fedex.CalculateTotalArea(); //fedex box area alone is 200 so this should produce
            //250 i.e. 50 for UPs box (stored in variable total plus the 200 for fedex TotalArea

            //The 'total +=' operator means sth like "value stored in 'total' plus area for fedex box

            /*The result of Ups TotalArea above which was stored within variable 'total' will now
             * be added to the TotalArea of FedEx box and this produces ALL the total areas for 
             * both boxes*/

            Console.WriteLine(total);

        }
    }
}
