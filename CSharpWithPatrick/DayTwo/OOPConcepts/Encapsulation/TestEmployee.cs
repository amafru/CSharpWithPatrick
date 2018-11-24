using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.OOP_Concepts.Encapsulation
{
    class TestEmployee
    {
        static void Main()
        {
            /*So if I create and Employee object 'alex' and call setTotalPay
             * passing in 120k as the salary amount
             * This should fail when I run program because 120k is over the 100k range 
             * Calculate TotalPay should return 0
             * And I should get a msg requiring I recheck salary amount entered*/ 

            Employee alex = new Employee();

            alex.setTotalPay(120000);
            alex.CalculateTotalPay();

            //Run it!

            Console.WriteLine("---------------");

            //And this one below should pass and show us the right figures for Lynda

            Employee lynda = new Employee();

            lynda.setTotalPay(80000);
            lynda.CalculateTotalPay();
            

            //Run it! 
            //(We should get 96k printed to console)

            /*Now what if I want to print the bonus for an employee called John?
             * I can't create a john object and call john.bonus because bonus is Private (see Employee class data)
             * And we don't want to just make bonus public from employee class
             * cuz that goes against the programming rules decided for this particular software.
             * 
             * What do we do now?
             * 
             * There are two possible solutions. See Employee class for them, then 
             * Come back here for implementation below*/

            //Solution 1:
            Employee john = new Employee();

            john.setTotalPay(100000);
            john.CalculateTotalPay();
            Console.WriteLine("John's bonus is = " + john.bonus); //this calls the bonus returned from within GetBonus method

            //Run it!

            /*Solution 2:
            *Implemented same as above and works
            *only difference is we changed the access modifier for data bonus to 'public' in 
            *Employee class and added {private set; get} to it to make sure it's range is set 
            * privately still, even though it's accessible for display publicly
            * 
            * Cool eh!?
        }
    }
}
