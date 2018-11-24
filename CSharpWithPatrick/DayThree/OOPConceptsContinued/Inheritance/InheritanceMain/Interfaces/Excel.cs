using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Inheritance.InheritanceMain.Interfaces
{
    class Excel : Office
    {
        public void New()
        {
            Console.WriteLine("Create New Excel Document");
        }

        public void Save()
        {
            Console.WriteLine("Save Excel Document");
        }

        public void Print()
        {
            Console.WriteLine("Print Excel Document");
        }

        /*Now create some objects in the TestOffice class and call some of these methods
         * Check it!
         */
    }
}
