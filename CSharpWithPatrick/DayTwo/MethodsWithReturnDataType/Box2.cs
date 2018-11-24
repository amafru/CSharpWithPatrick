using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.MethodsWithReturnDataType
{
    class Box2
    {
        public int length;
        public int width;

        /*To make the method return a value to a variable e.g. 'totalArea' we
         * Take out the 'void' modifier and replace it with 
         * a datatype of the kind we intend to return which is usually same datatype as used inour 
         * Formula
         * So.. if we intend to return an integer, this method will be 'public int CalculateTotalArea'
         * if we intend to return a string it'll be 'public string ....' etc (get the idea?)
         * THEN we add the 'return' keyword and define the variable for it to return our values to
         * In this case, that variable is called 'totalArea'*/

        public int CalculateTotalArea()
        {
            int totalArea = length * width;
            return totalArea;

            //See accompanying 'TestBox2' class for continuation
          
        }
    }
}
