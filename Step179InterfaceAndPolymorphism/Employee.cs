using Step179InterfaceAndPolymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step176AbstractClass
{
    class Employee: Person, IQuitable
    {
        public void Quit()
        {
            Console.WriteLine($"{firstName} says \"I quit!\"");
        }

        public override void SayName()
        {
            Console.WriteLine("Employee Name:");
            base.SayName();
        }
    }
}
