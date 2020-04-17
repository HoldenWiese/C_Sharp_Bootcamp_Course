using Step176AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Step184OverloadingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Holden = new Employee(fName: "Holden", lName: "Wiese", id: 123);
            Employee Jen = new Employee("Jen", "Hardin", 111);
            Employee Thomas = new Employee("Thomas", "Wiese", 123);

            Console.WriteLine(Holden == Jen);
            Console.WriteLine(Jen != Holden);

            Console.WriteLine(Holden == Thomas);
            Console.WriteLine(Thomas != Holden);


            Console.Read();
        }
    }
}

//1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.