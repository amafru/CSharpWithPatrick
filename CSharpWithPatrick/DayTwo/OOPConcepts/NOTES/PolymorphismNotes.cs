using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.OOP_Concepts
{
    class PolymorphismNotes
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
         * ************POLYMORPHISM***
         * Polymorphism is made up of two concepts
         * 
         * Method overloading AND Method Overriding
         * 
         * -Overloading is covered in Patrick video 2
         * -Overriding in Patrick video 3
         * 
         *****************************Overloading***
         * 
         *  is when objects of the SAME are differentiated by the compiler
         * ...during implementation based upon their passing arguments
         * i.e. when a programming language is smart enough to call the right method, based upon 
         * the format and number of the passing arguments entered
         * 
         * e.g. if I have two methods
         * public void CarMiles (double currentSpeed)
         * public void CarMiles (int carAge, int car distance)
         * 
         * If I call these two methods in a subclass using a variable 'peugeot' as
         * 
         * peugeot.CarMiles(50.5) 
         * peugeot.CarMiles(5, 172)
         * 
         * The oop language compiler knows just from this instantiation that 
         * The first call is for the first method, seeing as that's the method which accepts
         * ...a 'double' value
         * And second call is for the 2nd method, seeing as that' the one which accepts two parameters
         * of the type integer
         * 
         * 
         * See Polymorphism folder>Overloading for implementation.
         * 
         * 
         * ******************************Overriding***
         * 
         * Method overriding is when a subclass inherits a method from a superclass (as it should)
         * BUT  provides a different implemtation of that method
         * 
         * The super class has to allow the sub class to perform the override by using the 
         * keyword VIRTUAL in the specific method name definition. E.g. to override the method
         * 'BigCars' from the super class, the method name in SUPERCLASS must be specified as:
         * 'public virtual (void) BigCars, - The void is not required of course as it's a return type
         * 
         * And the subclass has to implement the override by using the 
         * keyword OVERRIDE in the specific method name definition. E.g. to override the method
         * 'BigCars' from superclass within the SUBCLASS, the method must be specified as:
         * 'public override (void) BigCars' when called inside the subclass
         * 
         * See Polymorphism>Overriding folder for implementation
         * 
         * */
    }
}
