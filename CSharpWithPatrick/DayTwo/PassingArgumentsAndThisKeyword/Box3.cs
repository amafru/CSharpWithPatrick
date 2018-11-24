using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.PassingArgumentsAndThisKeyword
{
    class Box3
    {
        public int length; //These are called 'class level data'
        public int width;

        //Parameters and passing arguments

        public int CalculateTotalArea(int length, int width) /*these in brackets are called 'parameters'
             *ALSO KNOWN AS method LEVEL data
             */


        /*when we call this method from another class and add values in brackets for these parameters
        * those values are called 'Passing arguments' (See accompanying 'TestBox3' class for implementation of passing arguments)
        */

        /*When we include passing arguments, the computer will use these by default NOT the 
         * class level data...
         * To check this is true, without implementing the 'this' keyword, 
         * Double click on 'length' and 'width' below, it'll highlight lenghth and width in brackets above
         * 
         * If we want to convert the the method level data to class level data,
         * We use the 'this' keyword as below
         *Now when we double click length and width below, it'll highlight the class level length and width above
         *Notice difference in clicking 'this.length' and 'width' below*/
        {
            int totalArea = this.length * width;
            return totalArea;

            

        }
    }
}
