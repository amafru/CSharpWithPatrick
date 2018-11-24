using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Inheritance.InheritanceMain.Interfaces
{
    class Word : Office
    {
        public void New()
        {
            Console.WriteLine("Create New Word Document");
        }

        public void Save()
        {
            Console.WriteLine("Save Word Document");
        }

        public void Print()
        {
            Console.WriteLine("Print Word Document");
        }
    }
}
