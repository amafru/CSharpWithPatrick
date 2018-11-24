using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.Constructors
{
    class TestSmallBox
    {
        static void Main()
        {
            SmallBox fedex1 = new SmallBox();
            /*By simply creating this object, the constructor was fired (instantiated)
             * And it's default values of length 6 and width 5 were applied to the object
             * Therefore no need to call the individual variables of width and length as normal
             * e.g. no need to say 'fedex1.length = 6' as with a normal method
             * 
             * We can simply move on to calling the CalculateTotalAreaMethod*/

            fedex1.CalculateTotalArea();

            //Now run this. 
            //Total area of 30 should display, as well as msg 'Constructor fired'


            //Now we can create several objects of SmallBox easily like this

            SmallBox fedex2 = new SmallBox();
            fedex2.CalculateTotalArea();

            SmallBox royalMail = new SmallBox();
            royalMail.CalculateTotalArea();

            //Run it!

            /***We can also overload the constructor by defining a new constructor which 
             * Takes passing arguments. See Overloaded constructor defined in SmallBox class*/

            Console.WriteLine("-----------------");

            SmallBox Ups1 = new SmallBox(10, 5); //This passes 10 as length and 5 as width of this particular box
            Ups1.CalculateTotalArea();

            //Run it! (totalArea should be 50 and msg 'Overloaded Constructor fired' printed 
        }
    }
}
