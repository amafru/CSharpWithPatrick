using CSharpWithPatrick.DayTwo.EmployeeExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.EmployeeExampleClassesAndObjects
{
    class TestEmployee
    {
        static void Main()
        {
            /*notice the new 'Using' at the top 'CSharpWithPatrick.DayTwo.EmployeeExample
             * It tells the visual studio compiler where we're calling the Employee class from
             * in order to create the object alex*/

            Employee alex = new Employee();
            Employee lynda = new Employee(); // This how we create objects

            /*Now when we call 'alex' and add a . we should see some of the data variables from the 
             * Employee class*/

            alex.salary = 90000;
            alex.bonus = 20000;
            alex.CalculateTotalPay();

            lynda.salary = 100000;
            lynda.bonus = 50000;
            lynda.CalculateTotalPay();

            //If we run this program now, we should see the respective totals printed to Console.
        }
    }
}
