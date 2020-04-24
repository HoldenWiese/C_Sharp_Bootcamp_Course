using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step202LambdaFunctions
{
    public class Employee : Person
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
    }
}
