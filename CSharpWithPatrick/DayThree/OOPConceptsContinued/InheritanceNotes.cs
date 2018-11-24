using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayTwo.OOP_Concepts
{
    class InheritanceNotes
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
         * *************************INHERITANCE Basics*** 
         * 
         *                 The basic Inheritance concept is when a class inherits
         *                 all the properties (data and methods) of another class
         *                 (except PRIVATE properties) 
         * 
         * - Tends basic quality tends to come in handy for Polymorphism's 'Overriding' - i.e 
         *   where we use the keywords 'virtual' and 'override' to perform a method override.
         * 
         *                  In order to implement method overriding
         *                  we need to implement the basic Inheritance
         *                  quality of defining a SuperClass/SubClass
         *                  relationship as below.
         *                  
         *                  e.g. If we have two classese 'Box' and 'BigBox' where
         *                  BigBox inherits from box, We implement this basic inheritance
         *                  property using the namespace of the inheriting class e.g.
         *                  
         *                  BigBox : Box
         *                  
         *                  (This means BigBox class inherits from Box class)
         *                  
         *                
         * --------- See classes inside OverridingWithInheritance in Day2>Polymorphism and -----
         * ---------SuperClassSubClassRelationship folder under Day3>Inheritance>InheritanceBasics ----
         * ----------------- within the OOP Concepts main folders ------------------------------
         *            
         * 
         * *************************INHERITANCE Main***             
         *                   
         * -Inheritance as a main concept is broken down into two component qualities 
         *                  'ABSTRACT CLASSES' and 'INTERFACES' 
         * 
         * ABSTRACT CLASSES
         * 
         * An abstract class is a class which has fully defined methods and abstract (empty) methods
         * They are useful when we don't know exactly what variables will be contained within
         * a method e.g. when building software for a third party, or defining a method to 
         * implement a database connection string and we're not yet sure what database will be 
         * used, and/or don't have the exact connection string to hand.
         * 
         * Abstract methods must contain the keyword 'Abstract' in their names e.g
         * 'public abstract void CalculateTime'
         * 
         * and 
         * 
         * Classes which contain abstract methods must also contain the keyword 'Abstract' in 
         * their namespace e.g. 'abstract class Time'
         * 
         * There are also other programming advantages to abstract methods...
         * 
         * Please see the classes in Day3>OOPConcepts>InheritanceMain>AbstractClasses.         
         *  
         *  
         *  INTERFACES
         *  An interface is a class which has ONLY empty methods
         *  They are used for implementing hegemony/uniformity within a project
         *  
         *  e.g. imagine you're Program manager in charge of developing software for 
         *  Microsoft Office and you have different teams working on MsOffice, MsExcel etc. 
         *  You also know that each software type is gonna have a CreateNew, Save and Print 
         *  functions(methods) say... And you want to make sure that there is uniformity in the 
         *  naming convention for those methods accross all teams AND crucially, that one team 
         *  doesn't completely forget to include one of those fucntionalities (methods). 
         *  
         *  Interface class(es) can be useful in this situation
         *  
         *  *********To create an interface class, we change the name e.g. 'class Office'*********** To
         *  ****************************'interface Office'**************************************
         *  
         *  We'll create an interface class called 'Office' and have other classes for MsWord etc
         *  inherit from the office class. (think of the classes as teams in this case. ha!)
         *  
         *  See DayThree> OOpConcepts> Inheritance> InheritanceMain> Interfaces 
         *  The classes in ther contain implementation
         * */
    }
}
