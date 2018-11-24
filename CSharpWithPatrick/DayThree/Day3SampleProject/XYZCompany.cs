using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Day3SampleProject
{
    class XYZCompany
    {
        static void Main()
        {
            Employee alex = new Employee("Alex Rod", 6);
            Employee lynda = new Employee("Lynda Berry", 7);
            Employee john = new Employee("John Doe", 3);
            Employee sara = new Employee("Sara Time", 7);
            Employee james = new Employee("James Doe", 4);

            Department sales = new Department("XYZSales");
            sales.addEmployeeToDept(alex);
            sales.addEmployeeToDept(lynda);
            sales.addEmployeeToDept(john);

            sales.depBudgetSummary();

            Department IT = new Department("XYZIT");
            IT.addEmployeeToDept(sara);
            IT.addEmployeeToDept(james);

            IT.depBudgetSummary();

        }
    }
}
