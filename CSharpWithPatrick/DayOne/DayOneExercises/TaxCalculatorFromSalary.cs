using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayOneExamples.DayOneExercises
{
    class TaxCalculatorFromSalary
    {
        static void Main()
        {
            /*Calculate Tax for a person earning £45000 where
             * 10% tax is paid on earnings under £8350
             * 15% on earnings between £8350 and £33950 and
             * 25% on earnings over £33950


            //double salary = 45000;
            //double tax;

            //if(salary <= 8350)
            //{
            //    tax = 8350 * 0.10;
            //}
            //else if (salary <= 33950)
            //{
            //    tax = ((8350 * 0.10) + ((salary - 8350) * 0.15));
            //}
            //else
            //{
            //    tax = ((8350 * 0.10) + ((33950 - 8350) * 0.15) + (salary - 33950) * 0.25);
            //}

            //Console.WriteLine("Tax due is equal to " + tax);




            //The above code contains too much hard coding which is bad practice. Let's refactor

            /*First, we'll allow the user to enter their salary amount into console instead of assuming
             * an amount*/

            Console.WriteLine("Please enter your salary: ");

            double salary = Convert.ToDouble(Console.ReadLine());
            double tax;

            if (salary <= 8350)
            {
                tax = 8350 * 0.10;
            }
            else if (salary <= 33950)
            {
                tax = ((8350 * 0.10) + ((salary - 8350) * 0.15));
            }
            else
            {
                tax = ((8350 * 0.10) + ((33950 - 8350) * 0.15) + (salary - 33950) * 0.25);
            }

            Console.WriteLine("Tax due is equal to £" + tax);
        }
    }
}
