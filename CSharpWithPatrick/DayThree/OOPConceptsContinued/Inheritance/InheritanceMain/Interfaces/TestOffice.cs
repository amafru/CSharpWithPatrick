using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWithPatrick.DayThree.OOPConceptsContinued.Inheritance.InheritanceMain.Interfaces
{
    class TestOffice
    {
        static void Main()
        {
            Office work1 = new Word();
            work1.New();

            work1 = new Excel();
            work1.Save();
        }
    }
}
