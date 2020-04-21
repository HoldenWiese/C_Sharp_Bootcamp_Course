using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step187Generics
{
    class Employee<T> : Person
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


        //Generics
        public List<T> things { get; set; }

        public void thingsLoop()
        {
            foreach (T thing in things)
            {
                Console.WriteLine($"{thing} is a thing that {firstName} has!");
            }
        }
        
    }
}
