using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.static_keyword
{
    class ExampleStatic
    {
        public static int staticCount;
        public int nonstaticCount;

        public void CallStaticCount()
        {
            Console.WriteLine("Static count = " + staticCount);
            staticCount++;
        }

        public void CallNonStaticCount()
        {
            Console.WriteLine("Non Static count = " + nonstaticCount);
            nonstaticCount++;
        }

        /*Also see the constructors below:
         * First one is static and gets fired before
         * Second one which is an 'instance constructor*/

        static ExampleStatic() //doesn't need an access modifier e.g. 'public', as it's a static constructor. If you put one, you get a red squiggly telling you the same
        {
            Console.WriteLine("Static Constructor is fired");
        }

        public ExampleStatic() //needs access modifier e.g. 'public', as it's an instance constructor. 
                               //All normal non static methods, variables and constructors are known as 'instance' variables 
        {
            Console.WriteLine("Non Static Constructor 'aka instance constructor' is fired");
        }
    }
}
