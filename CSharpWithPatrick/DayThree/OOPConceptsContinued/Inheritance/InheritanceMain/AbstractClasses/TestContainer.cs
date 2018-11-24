using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Inheritance.InheritanceMain.AbstractClasses
{
    class TestContainer
    {
        static void Main()
        {
            SquareContainer squareObj1 = new SquareContainer();
            squareObj1.CalculateVolume(5, 4);
            /* This call takes the passing arguments (Height 5 and Length 4) from the passing 
             * arguments, adds those to the CalculateVolume formula from Container class, then
             * uses the length value (4) and passes that as an argument in the AreaOfBase passing
             * parameters, then uses that length in the Area of base formula for 'area' 
             * (i.e. length * length) to produce the final area for Square Container
             * Which it prints to console.
             * 
             * Same is true for circle container etc 
             *  
             * Hell of a Thing!
             */

            CircleContainer CircleObj1 = new CircleContainer();
            CircleObj1.CalculateVolume(5, 5);

            ConeContainer ConeObj1 = new ConeContainer();
            ConeObj1.CalculateVolume(3, 3);

            //Run it!

            /*KEEP IN MIND
             * 
             * ANOTHER ADVANTAGE OF INHERITANCE
             * 
             * We can create one object of a Superclass and reuse that same object to run several
             * method calls for all the Sub classes, in doing doing, saving on computer memory 
             * usage. See examples below.
             */

            Console.WriteLine("-------------------");

            Container c1 = new SquareContainer();
            c1.CalculateVolume(3, 3);

            c1 = new CircleContainer();
            c1.CalculateVolume(10, 10);

            c1 = new ConeContainer();
            c1.CalculateVolume(4, 4);

            //Run it!
        }
    }
}
