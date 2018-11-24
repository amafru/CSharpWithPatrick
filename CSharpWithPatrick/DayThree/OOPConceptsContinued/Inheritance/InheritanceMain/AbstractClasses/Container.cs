using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Inheritance.InheritanceMain.AbstractClasses
{
    abstract class Container
    {
        /* Imagine we have 3 containers to calculate the volumes of.
         * A square container, a circle one and a cone
         * Obviously we'll need different values e.g. length, height, base etc in order to 
         * calculate the volumes. 
         * 
         * And let's assume we want to define 3 different methods for calculating the volume
         * of each of these containers....
         * 
         * We can use method astraction to our advantage to do this.
         * 
         * Define a base class called 'container' with the basic Calculate volume method
         *
         */
        public void CalculateVolume(int height, int length)
        {
            double volume = AreaOfBase(length) * height;
            //Console.WriteLine("Overall ContainerS volume is = " + volume);

            /*As we can see, the above definition for CalculateVolume calls within it another
             * method AreaOfBase.
             * That AreaOfBase method is (let's assume) the one which we don't know yet what
             * specific parameters that will be included within it. 
             * 
             * So we need to declare AreaOfBase as an abstract method. See below
             */       
        }

        public abstract double AreaOfBase(int length);
        /*When we use the 'abstract' keyword, we no longer need to use the 'virtual' keyword
         * in order to allow an override of this method in the other class 'circle' etc
         * 
         * The datatype of this abstract class i.e. 'double' MUST MATCH the datatype of the
         * variable i.e. 'volume' which calls the AreaOfBase method above. 
         * Otherwise, we'll get a squiggly  on the 'volume' method above
         * 
         * Now let's go use this AreaOfBase method within the circle, square and cone classes
         * to define the unique measurement parameters of each container type and then call
         * CalculateVolume from a TestContainer class to calculate each container's unique volumes.
         * 
         * Note that Circle, Square and Cone classes will all inherit from 'Container' class, 
         * so that they have access to the method 'CalculateVolume')
         * 
         * 
         */
    }
}
