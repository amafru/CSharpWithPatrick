using CSharpWithPatrick.DayThree.OOPConceptsContinued.Day3SampleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.Collections.Lists_GenericList
{
    class ExampleGenericList
    {
        static void Main()
        {
            /*LIST falls under a kind of collection calle 'GENERIC COLLECTIONS'
         * 
         * This means that even though just like an ArrayList, a list can hold an unlimited 
         * number of objects, the datatype of said objects needs to be clearly defined when 
         * creating a List e.g. List of string objects, list of integers etc
         * 
         * Here's the syntax for creating a new List
         */

            List<string> myGenericList = new List<string>();

            //We can then add objects to this list like so
            myGenericList.Add("zero");
            myGenericList.Add("one");
            myGenericList.Add("two");
            myGenericList.Add("three");
            myGenericList.Add("four");

            /*And besides looping through each element and printing to console 
             *we can manipulate these objects like this*/

            Console.WriteLine("Original Count : " + myGenericList.Count()); //Will tell us how many elements there are in the list
            Console.WriteLine("---------------"); //spacer

            Console.WriteLine(myGenericList.Remove("zero")); //Will remove the object of name "zero" from the list and print a boolean result to the console i.e. true if remove is a success
            Console.WriteLine("---------------"); //spacer

            Console.WriteLine("New Count : " + myGenericList.Count()); //Should print a new count of the objects in the list with 1 removed i.e. no "zero" as per prior instruction
            Console.WriteLine("---------------"); //spacer

            Console.WriteLine(myGenericList[2]); //Print an item in a specific index location. This particular example should print "three" from myGenericList
            Console.WriteLine("---------------"); //spacer

            //And of course we can loop through the list objects and print 

            foreach (string temp in myGenericList)
            {
                Console.WriteLine(temp);
            }



            //We can also create an Employee list like this

            List<Employee> employeeList = new List<Employee>(); //namespace for Employee added above

            //Then add objects to the Employee list like this
            //First we create the employee objects

            Employee lynda = new Employee("Lynda Berry", 7);
            Employee john = new Employee("John Doe", 6);
            Employee sara = new Employee("Sara Time", 4);

            //Then we add them to the employee list like this
            employeeList.Add(lynda);
            employeeList.Add(john);
            employeeList.Add(sara);
            

            
            
        }

    }
}
