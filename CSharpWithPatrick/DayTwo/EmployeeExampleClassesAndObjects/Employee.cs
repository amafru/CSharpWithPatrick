using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.EmployeeExample
{
    public class Employee
    {
        /*CLASSES & OBJECTS
         * Our objective in this example is to create 2 classes 
         * "Employee" with all the data definitions and methods
         * and "Test Employee" with objects to call those methods and data*/

        public double salary;
        public double bonus;

        public void CalculateTotalPay() //This is a method. This syntax of capial and small letters is known as Pascal case or Camel case
        {
            double totalPay = salary + bonus;

            Console.WriteLine("Total Pay = " + totalPay);
        }
    }
}
