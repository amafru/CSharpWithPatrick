using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.Constructors
{
    class SmallBox
    {
        /*CONTSTRUCTORS...
         * A constructor is a method which:
         * -Carries the same name as the class
         * -Does NOT specify any return method or data type e.g. void or string
         * -Is instantiated and implemented by default whenever an object of that class is created
         * -Is used to specify default values to be used within objects of that class
         * See below*/

        int length;
        int width;
        

        public SmallBox() //notice, no 'void' or datatype keyword like 'string'. 
            //THIS IS THE SYNTAX FOR A CONSTRUCTOR
        {
            length = 6;
            width = 5;

            Console.WriteLine("Constructor fired...");
        }

        public void CalculateTotalArea() //Now this is a normal method. Notice 'void' return keyword
        {
            int totalArea = length * width;
            Console.WriteLine("Total Area = " + totalArea);
        }

        //So now if we call the constructor from another class 'TestSmallBox' we can see it working

        //***OVERLOADED CONSTRUCTOR

        public SmallBox(int length, int width)
            /*by adding parameters. We've prepared this constructor for overloading
             * And if we want to take this length and width in brackets and use them as
             * ...the class level length and width. We simply use the 'this' keyword as below*/
             
        {
            this.length = length; //Double click on word 'length' and the length called is highlighted for verification
            this.width = width;

            Console.WriteLine("Overloaded Constructor fired...");

            //See TestSmallBox class for implementation
        }
    }
}
