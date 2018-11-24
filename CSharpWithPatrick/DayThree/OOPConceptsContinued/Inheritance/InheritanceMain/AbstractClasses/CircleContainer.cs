using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Inheritance.InheritanceMain.AbstractClasses
{
    class CircleContainer : Container
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
            double area = Math.PI * (length / 2)  * (length / 2);
            Console.WriteLine("Area of circle Container = " + area);
            return area;
        }
    }
}
