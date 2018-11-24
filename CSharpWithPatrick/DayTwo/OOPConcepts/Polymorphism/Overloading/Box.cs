using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.OOP_Concepts.Polymorphism
{
    class Box
    {
        public void CalculateTotalArea(double length)
        {
            Console.WriteLine("Total Area is = " + length * length);
        }

        public void CalculateTotalArea(int length, int width)
        {
            Console.WriteLine("Total Area is = " + length * width);
        }

        public void CalculateTotalArea(double length, int width)
        {
            Console.WriteLine("Total Area is = " + length * width);
        }

        //Then I call these 3 methods from accompanying TestBox class
    }
}
