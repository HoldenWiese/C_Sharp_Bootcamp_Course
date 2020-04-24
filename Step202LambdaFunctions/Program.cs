using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step202LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Joe", "Johnson", 4),
                new Employee("Holden", "Wiese", 6),
                new Employee("Tom", "Edison", 8),
                new Employee("Bill", "Nye", 1),
                new Employee("Mario", "Ninten", 2),
                new Employee("Zowie", "Fast", 3),
                new Employee("Haley", "White", 5),
                new Employee("Burt", "Peyton", 7),
                new Employee("Nana", "Yups", 9),
                new Employee("Joy", "Montoya", 10)
            };

            //Using a foreach to find all Joe's
            List<Employee> myJoes = new List<Employee>();
            foreach(Employee employee in employees)
            {
                if (employee.firstName.Contains("Joe"))
                {
                    myJoes.Add(employee);
                    Console.WriteLine(employee.firstName);
                }
            }

            //Using a lambda function
            List<Employee> joes = employees.Where(x => x.firstName.Contains("Joe")).ToList();

            foreach (Employee person in joes)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }

            //All employees with id greater than 5
            List<Employee> greaterThan5 = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee person in greaterThan5)
            {
                Console.WriteLine($"{person.firstName} {person.lastName} {person.Id}");
            }
            Console.ReadLine();
        }
    }
}

//1. In the Main() method, create a list of at least 10 employees.Each employee should have a 
//   first and last name, as well as an Id.At least two employees should have the first name "Joe".
//2. Using a foreach loop, create a new list of all employees with the first name "Joe".
//3. Do the same thing again, but this time with a lambda expression.
//4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
