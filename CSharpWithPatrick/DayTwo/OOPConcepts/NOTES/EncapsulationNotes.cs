using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.OOP_Concepts
{
    class EncapsulationNotes
    {
        //FOR VIDEO HELP. SEE PATRICK VIDEOS. DAY 2. TOWARDS THE END OR THE VIDEO

        /*For a language to be considered a true Object Oriented programming language
         * It MUST support the concepts of
         * ENCAPSULATION: Data hiding e.g. public, protected, private access modifiers
         * POLYMORPHISM: Overloading and Overriding AND
         * INHERITANCE: Abstract classes and Interfaces
         * 
         * True OOP languages include c#, Java and c++
         * 
         * 
         * ************ENCAPSULATION***
         * Encapsulation is the concept of having DATA and METHODS which ACT ON THE DATA in THE 
         * ...SAME CLASS.... (key! DATA.... METHODS WHICH ACT ON THE DATA.... SAME CLASS)
         * 
         * It's mainly about data hiding using such tools as access modifiers to control data access and manipulation
         * 
         * ***Meanings of the access Modifiers
         * 'public' - Makes the class/method accessible on a class, sub class (where objects are created) and project level
         * 'protected' - Makes the class/method accessible on a class and sub class level
         * 'private' - Makes the class/method accessible on a class level
         * 
         * NOTE: Where no access modifier is specified c# considers the method/class as Private!
         * 
         * Other aids that can be used alongside access modifiers include
         * {get; set;} definitions
         * 
         * For instance if I declare a method 'public double TotalPay{private set; get}'
         * ...which contains variables 'public double salary' and 'public double bonus'
         * This means:
         * I SET the default values/range of Salary and Bonus within the current class. They remain private 
         * and cannot be manipulated e.g. overloaded using a method within a sub class
         * I can GET e.g. display the value of e.g bonus, from within a sub class by using an object
         * e.g. I can display the bonus only by calling 
         * 
         * Console.WriteLine("Bonus is = " + alex.bonus);
         * 
         * But I cannot SET the bonus using the alex object as in alex.bonus = 2000. Cuz it's private set
         * 
         * SEE ENCAPSULATION FOLDER for example implementation*/
    }
}
