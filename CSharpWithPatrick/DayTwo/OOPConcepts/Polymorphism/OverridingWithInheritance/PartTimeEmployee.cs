using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.OOPConcepts.Polymorphism.Overriding
{
    class PartTimeEmployee : Employee
    {
        public void PrintContractDetails()
        {
            Console.WriteLine("Print contract details for Part Time Employees of Xyz");
        }

        public override void CalculateHoliday(int empGrade)
        {
            int annualHoliday = 0;

            if (empGrade > 5)
            {
                annualHoliday += 8;
            }
            else
            {
                annualHoliday += 4;
            }
            Console.WriteLine("Total annual holiday allowed: " + annualHoliday);
        }
    }
}
