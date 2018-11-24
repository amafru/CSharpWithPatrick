using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Day3SampleProject
{
    class Employee
    {
        private string empName;
        public int empGrade { private set; get; }

        public Employee(string empName, int empGrade)
            //This is a constructor which enables us to create objects of Employee in Department class
        {
            this.empName = empName;
            this.empGrade = empGrade;
        }

        public override string ToString() //This method name was changed to 'ToString' in DayFour cuz this method is call from the ExampleArray_List class there. See notes in that ExampleArray_List class
        {
            string status = empName + "(" + empGrade + ")";
            return status;
        }
    }
}
