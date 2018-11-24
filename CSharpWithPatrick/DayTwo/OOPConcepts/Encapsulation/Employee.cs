using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.OOP_Concepts.Encapsulation
{
    class Employee
    {
        /*Say we wanted to create a program where the salary range for given company is set to 
         * 50000 - 100000
         * And Bonus would be 20% of salary value for any given employee
         * 
         * And we want to ensure no one can enter a salary of say 120000 or any thing over 100k
         * ...and nothing below 50k either
         * 
         * We can implement this as below*/

        private double salary;
        public double bonus { private set; get; }

        public void setTotalPay(double salary)
        {
            if (salary < 50000 || salary > 100000) //This sets the acceptable pay range
            {
                Console.WriteLine("Please recheck salary amount. Must be more than 50k and less than 100k");
                this.salary = 0;
                this.bonus = 0;
            }
            else
            {
                this.salary = salary;
                this.bonus = salary * 0.20; //this says take 20% of salary and assign that as the bonus figure
            }
        }

        public void CalculateTotalPay()
        {
            double totalPay = salary + bonus;
            Console.WriteLine("Total Pay is = " + totalPay);
        }

        //Now see accompanying test employee class for implementation


        /*For the print bonus problem. 
         * Solution 1:
         * We leave the bonus variable above as a private variable 
         * And declare a method which returns a value e.g. 'public double GetBonus'
         * which returns a value... 'bonus'
         * And then call this GetBonus class in the TestEmployee class like
         * Console.WriteLine("Bonus = " + john.GetBonus)*/

        public double GetBonus()
        {
            return bonus;
        }

        /*Solution 2: 
         * We can change the bonus variable above to a public variable 
         * And define it's 'get' and 'set' modifiers as {private set; get} as above
         * Then call the bonus from TestEmployee class
         * See TestEmployee class*/
    }
}
