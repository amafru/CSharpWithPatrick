using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.base_Keyword
{
    class Cube : Square
    {
        protected int randomNumber = 20; //ignore the green squiggly on randomNumber. It's just saying we have another randomNumber inherited from Square class available to us if we want it

        public override double CalculateArea(int length)
        {
            double volume = base.CalculateArea(length) * 6; //Calling superclass calculatearea and multiplying it by 6 to get volume of cube
            Console.WriteLine("Cube Volume is = " + volume);
            Console.WriteLine("Random number for Cube is = " + randomNumber); //print randomNumber for this class Cube
            Console.WriteLine("Random number for Square is = " + base.randomNumber); //now printing randomNumber for Square class using the 'base' keyword
            return volume;
        }
    }
}
