using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOneExamples
{
    class SwitchCaseStatement
    {
        static void Main()
        {
            string j = "two";

            switch (j)
            {
                case "one":
                    Console.WriteLine("The value is one");
                    break;
                case "two":
                    Console.WriteLine("The value is two");
                    break;
                case "three":
                    Console.WriteLine("The value is three");
                    break;
                default:
                    Console.WriteLine("Value not found");
                    break;

            }

        }
    }
}
