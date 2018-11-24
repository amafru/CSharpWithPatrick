using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.OOPConcepts.Polymorphism.Overriding
{
    class CompanyXyz
    {
        static void Main()
        {
            /*We have 2 employees
             * Kelly who is full time, (for full time employees we only want to calculate their 
             * total pay and holidays based on standard company parameters - defined using in 
             * Employee class)
             * 
             * Ama who is part time (for part timers we want to calculate their pay and holiday 
             * and also print their contract details to screen. Hence why the print contract 
             * instruction is defined within the part time employee class.
             * 
             * But we want to implement a method of calculating holiday for part time employee which
             * gives them less holiday days per year compared to full time employees like Kelly.
             * 
             * How do we do this?
             * We can't just copy and paste the CalculateHoliday method from Employee class into
             * PartTimeEmployee class and change the parameters in there. We'll get a squiggly line
             * warning us that a version of that method is already available to the PartTimeEmployee
             * class (The version that it inherited). 
             * But we still need to change our parameters to that method slightly, and we need to do 
             * it WITHOUT creating a 2nd method of CalculateHoliday for use by part time employees 
             * e.g. CalculateHoliday2
             * 
             * One main solution to this connundrum is method overriding
             * 
             * Notice the 'virtual' and 'override' keywords in the relevant classes and the "new" 
             * CalculateHoliday method in the PartTimeEmployee class 
             * 
             * */

            Employee kelly = new Employee();
            Employee dara = new Employee();
            PartTimeEmployee ama = new PartTimeEmployee();

            Console.WriteLine("Employee Kelly");
            kelly.CalculateTotalPay(120000);
            kelly.CalculateHoliday(7);
            Console.WriteLine("---------------------");

            Console.WriteLine("Employee Dara");
            dara.CalculateTotalPay(130000);
            dara.CalculateHoliday(4);
            Console.WriteLine("---------------------");

            //Part Time Employees below
            /*Having implemented method override, Ama's holiday days should be less than Kelly's
             * even though they are both of employee grade higher than 5
             * 
             * oop languages are clever enough to know that when we call CalculateHoliday for 
             * Ama, they should call the version of CalculateHoliday defined in PartTimeEmployees*/

            Console.WriteLine("Employee Ama");
            ama.CalculateTotalPay(100000);
            ama.CalculateHoliday(6);
            ama.PrintContractDetails();
            Console.WriteLine("---------------------");
        }


    }
}
