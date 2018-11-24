using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayFour.static_keyword
{
    class TestStatic
    {
        static void Main()
        {
            ExampleStatic obj1 = new ExampleStatic(); //As soon as we creat these objects, the constructors from within ExampleStatic class are fired.
            ExampleStatic obj2 = new ExampleStatic(); //Remember what Patrick said? Soon as we create an instance of a class, it's constructors are fired!
            //You can test this by commenting out the first 3 lines of code below and running the program. Constructors will still be fired.

            Console.WriteLine("-----------------"); //spacer

            /*Can't use 'obj1' or 'obj2' to call the variable 'staticCount' from ExampleStatic class
             * Error squiggly will appear. We call a static variable 
             * by calling the class name directly and specifying which variable we want.
             * As below: 
             * The following 3 lines of code are here to show the syntax for calling static and non-static (instance) variables.
             * They also show us how we can assign origin values for staticCount and nonStaticCount variables
             * i.e. in this case static count is instructed to start the count at '1'
             * 
             * And nonStaticCount is instructed to start BOTH instances of the count at '1'
             * See how this affects the operation of the program in the notes at the end below.
             */

            ExampleStatic.staticCount = 1; 
            /*We call the variables staticCount and nonstaticCount below and assign them 
             * origin integer values.
             * 
             * This is how we call a static variable. 
             * Notice that when we call 'ExampleStatic' class directly, we only get access to the static variable 'staticCount'*/

            //This is how we call a non static variable (instance variable). The normal way that we mostly use an object to all a variable...
            obj1.nonstaticCount = 1; //Notice when when we use 'obj1' we DON'T get access to 'staticCount' variable in intellisense
            obj2.nonstaticCount = 1;

            /*NOW....
             * You'll notice that when we ran the program at this stage, the non static constructor
             * is fired twice, while the static constructor is fired only once.... This is because
             * there are 2 objects 'obj1' and 'obj2' created up above.
             * And as we can't use objects to call a static variable, both objects created were used 
             * to fire the non-static constructor.
             * You can try commenting out one of those object creations. Notice that only one instance
             * of the non-static constructor is fired when the program is run after you do that.
             */

            Console.WriteLine("-----------------"); //spacer

            //Now let's use the objects to call the CallStaticCount and CallNonStaticCount methods

            obj1.CallStaticCount();
            obj2.CallStaticCount();
            obj2.CallStaticCount();

            Console.WriteLine("-----------------"); //spacer

            obj1.CallNonStaticCount();
            obj2.CallNonStaticCount();
            obj2.CallNonStaticCount();

            //Run it!

        }

        /*You'll notice when you run the program that the count printed for static method CallStaticCount
             * increases from 1-2-3. Because a new instance of a static variable is NOT created 
             * for every object that calls it, the compiler simply uses the same variable, in this 
             * case 'staticCount' and keeps a tally (count)
             * 
             * While for the instance method CallNonStaticCount it goes from 1-1-2, because when we've
             * called the variable nonStaticCount above an assigned it's original integer values
             * we've asked it to start at '1' twice (see obj1.nonStaticCount = 1) above.
             * So as an instance of an instance variable is created every time for every object 
             * that calls it, the count is able to start at '1' twice (as per specification)
             * when we run the program.
             * 
             * To test this, we can change one of the origin integers for 'obj1.nonStaticCount' above
             * to another number e.g. '0' and run the software. Notice nonStaticCount doesn't print
             * 1-1-2 this time
             * 
             * You can therefore see, how using static variables can be one way to save on memory
             * especially in large programs
             */
    }
}
