using Step179InterfaceAndPolymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step176AbstractClass
{
    class Employee : Person, IQuitable
    {
        public int Id { get; set; }
        public Employee(string fName, string lName, int id)
        {
            firstName = fName;
            lastName = lName;
            Id = id;
        }
        public void Quit()
        {
            Console.WriteLine($"{firstName} says \"I quit!\"");
        }

        public override void SayName()
        {
            Console.WriteLine("Employee Name:");
            base.SayName();
        }
        public static string operator ==(Employee person1, Employee person2)
        {
            if (person1.Id == person2.Id)
            {
                return "This is the same person";
            }
            else
            {
                return $"{person1.firstName} is not {person2.firstName}.";
            }
        }
        public static string operator !=(Employee person1, Employee person2)
        {
            if (person1.Id != person2.Id)
            {
                return $"{person1.firstName} is not {person2.firstName}.";
            }
            else
            {
                return "This is the same person";
            }
        }
    }
}
