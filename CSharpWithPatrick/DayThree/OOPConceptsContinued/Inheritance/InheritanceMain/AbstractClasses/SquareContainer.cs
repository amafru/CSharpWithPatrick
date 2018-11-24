using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Inheritance.InheritanceMain.AbstractClasses
{
    class SquareContainer : Container
    {
        /*As the AreaOfBase within this class will override the AreaOfBase from Container class
         * in order to define it's own unique parameters, we need the 'override keyword' below
         * 
         * When we type in 'override' and datatype for method called, e.g. 'double' intellisense
         * will prompt us with the abstract methods available to call. In this case it is
         * 'AreaOfBase(int length' that appears
         */
        public override double AreaOfBase(int length)
        {
            double area = length * length;
            Console.WriteLine("Area of Square Container = " + area);
            //The Console.WriteLine HAS to be written BEFORE the 'return area'...(no idea why)
            //squiggly line if it isn't!
            return area;
            
            /*So now we can go an create a new object for Square container within TestContainer
             * And call the CalculateVolume method for said square container
             * 
             * Check it!
             */
        }
    }
}
