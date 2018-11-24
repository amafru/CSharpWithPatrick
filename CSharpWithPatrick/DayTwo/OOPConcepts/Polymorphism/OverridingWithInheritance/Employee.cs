using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.OOPConcepts.Polymorphism.Overriding
{
    class Employee
    {
        double bonus;
        int annualHoliday = 0;

        public void CalculateTotalPay(double salary)
        {
            if(salary > 100000)
            {
                bonus = salary * .30;
            }
            else
            {
                bonus = salary * .20;
            }

            double totalPay = salary + bonus;
            Console.WriteLine("Total annual pay: " + totalPay);
        }

        public virtual void CalculateHoliday(int empGrade)
        {
            if(empGrade > 5)
            {
                annualHoliday += 10;
            }
            else
            {
                annualHoliday += 8;
            }
            Console.WriteLine("Total annual holiday allowed: " + annualHoliday);
        }

        //See CompanyXyz class for implementation of overrinding
    }
}
