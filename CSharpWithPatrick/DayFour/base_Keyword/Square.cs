using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.base_Keyword
{
    class Square
    {
        /*The 'base' keyword is used to call the Superclass's data and methods from another 
         * class.
         * In this example, Square is the superclass and Cube is subclass
         * Note how we call methods from Square using base keyword
         * 
         * Our task: Calculate area of a cube, using original CalculateArea method from Square 
         * class. 
         * Since the area of a cube is just 6 times area of a square, we can reuse the square's 
         * area method, override it within cube class and simply multiply the result by 6
         * 
         * See implementation starting below.
         */

        protected int randomNumber = 10; 
        //This is only here for further demonstrate use of 'base' keyword from cube class

        public virtual double CalculateArea(int length)
        {
            Console.WriteLine("Square Area is = " + (length * length));
            return (length * length);
        }
    }
}
