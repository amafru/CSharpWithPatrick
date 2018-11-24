using CSharpWithPatrick.DayThree.OOPConceptsContinued.Day3SampleProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.Collections.Lists_Arraylist
{
    class ExampleArray_List
    {
        /*DO NOT ever rename this class to ArrayList!
         * I made that mistake. It confuses the Common Runtime Library and Arraylist methods 
         * such as '.Add' will not work accordingly. Renamed to 'ExampleArray_List' to overcome that*/

        static void Main()
        {
            /*ArrayLists are an improvement over simple arrays
             * 
             * They fall under a type of collection called 'NON-GENERIC' COLLECTIONS
             * 
             * With simple arrays we have to specify the type of data we intend for the array to hold
             * And we also have to specify a maximum number of objects the array can hold e.g. 5 like below
             * 
             * string[] employees = new string[5]
             * 
             * What if we want to specicy a collection of objects without limitations as to data type and 
             * object capacity? We need a Non-Generic collection for that.
             * 
             * Enter ArrayLists (which is a part of 'Collections' in the .Net Library
             * 
             * ArrayLists can contain a mix of datatypes 'string', 'integers' 'double' etc
             * 
             * They also have no limit to the amount of objects they can hold
             * 
             */

            //Here's the syntax for creating a new ArrayList

            ArrayList myList = new ArrayList();

            //We can now add any assortment of data and objects to the list like so
            myList.Add(10); //An integer object
            myList.Add(1000.15); //A double object
            myList.Add("Peter"); //A string object
            myList.Add(true); //A boolean object

            //We can even add objects of datatype 'Employee' from our 'daythree>Day3SampleProject'
            //Like below:

            Employee alex = new Employee("Alex Rod", 5); //This method needed passing arguments of empName & empGrade (see daythree>Day3SampleProject>Employee class)

            /*Because we're calling 'Employee' from another class, in another folder, we needed to refer
             * to that folder>class in the namespaces (usings...) of this class. See above 'using CSharpWithPatrick.DayThree...etc'
             */

            //Having created (employee) object alex, we can now add him to the arraylist like so

            myList.Add(alex);

            /*We can loop through the arraylist using a foreach statemtn to print all it's 
             * variables to console. 
             * 
             * But...
             * 
             * because our array list contains variables of different data types we 
             * can't write a typical foreach statement. We need to call on a 'virtual' c#
             * class called 'Object'
             * Class 'Object' is not visible to the naked eye but in c#, every class, upon 
             * creation inherits from the Object class by default. i.e. every class ever 
             * created in c# in reality appears like this e.g. 'class NewClass : Object'
             * in visual studio's background. 
             * 
             * Object class can also be used as a datatype when there are several datatypes 
             * to call on in a list or array. It's a unigying datatype of sorts
             * 
             * We'll therefore use the Object data type for this foreach statement here
             */

            foreach(Object tempvar in myList)
            {
                Console.WriteLine(tempvar);

                //We can also write this as
                //Console.WriteLine(tempvar.ToString());
                /*Because the object class has a default virtual method called .ToString()
                 * which is ready to use in converting non-string objects e.g. int to string
                 * for display to console.
                 * However because this .ToString method is called by defaul. We do not need
                 * to add the .ToString() bit above, as again, it is added by default when we
                 * ask console to print tempvar. Just once again, not visible to the naked eye
                 * 
                 * You can place cursor over 'Object' above and press F12 to view this object class
                 */

                //Run it!

                /*When we run this application, you'll notice that instead of printing the
                 * name and grade for object alex as per the returnNameAndGrade() method from 
                 * 'daythree>Day3SampleProject', console simply prints the LOCATION of that 
                 * object within our program. To overcome this and print Alex's name and grade, 
                 * we need to use the fact that the 'virtual' Object class has a virtual
                 *  method called .ToString() to our advantage.
                 * 
                 * i.e. we need to go back to 'daythree>Day3SampleProject' from whence we've called
                 * and created the Employee object alex, and modify the returnNameAndGrade() method.
                 * 
                 * First we need to change the method name to 'ToString' so it matches the virtual
                 * ToString() method in the Object class.
                 * 
                 * Then we need to make the former (and now renamed) returnNameAndGrade() method
                 *  an 'override' method
                 *  
                 * Run It! (Now Alex's name and grade will be printed to console)
                 */

            

            }
        }
    }
}
