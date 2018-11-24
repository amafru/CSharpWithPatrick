using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Day3SampleProject
{
    class Department
    {
        private string depName;
        private double depBudget;

        private int counter = 0; 
        /*this variable 'counter' is declared so that we can at individual members to the 
         * Employee array below by looping 'counter ++' instead of declaring each one individually
         * e.g. Employee[0] = alex; Employee[1] = lynda; etc
         *It also enables us to loop later through the employee grades and auto increment the 
         *respective department budgets according to parameters using an IF ELSE statment*/

        Employee[] staffMembers = new Employee[5]; 
        /*This array allows us to create a variable 'staffMembers' which can hold a bunch of 
         * employees (up to 5 in this case)*/
         

        public void addEmployeeToDept(Employee obj)
            /*Using this 'addEmployeeToDept' method, we create the relationship between the 
             * employees and their respective departments, and use that relationship alongside the
             * employee grades, in a loop which calculates the total dept budget*/
        {
            staffMembers[counter] = obj;
            counter++;

            if (obj.empGrade > 5)
            {
                this.depBudget += 150000;
            }
            else
            {
                this.depBudget += 100000;
            } 
        }

        public void depBudgetSummary() 
            //We call this method from the XYZCompany class to print our final total dept budget
        {
            //string temp = "The total budget for " + this.depName + " is = " + this.depBudget;
            //Console.WriteLine(temp); 



            /*This snippet above will print a rather non-descriptive 450k and 300k to the console
             * We can make this display a more readable result like below*/


            string temp = "Department Name: " + this.depName + // \n is code shortcut for print New Line
                "\nDepartment Budget: " + this.depBudget +
                "\nEmployees: "; //We'll use a foreach statemt to print a list of all dep employees

            foreach (Employee tempvar in staffMembers)
            {
                if (tempvar != null) 
                    /*Because some of the spaces in our employee array are empty (i.e. contain 
                     * 'null' values, if we run this program withot the above 'if' statement/condition
                     * the computer will throw an 'unhandled null exception.'
                     * So we run the above snippet to say only loop and run the 'tempvar' command
                     * below, where the array spaces DO NOT  contain null values*/
                {
                    {
                        temp += tempvar.ToString() + " ";//calling this method from Employee class
                    }
                }
                Console.WriteLine(temp);
            }
        }


        public Department(string depName)
        {
            this.depName = depName;
            this.depBudget = 50000;
        }
    }
}
