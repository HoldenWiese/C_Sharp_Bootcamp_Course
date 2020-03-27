using System;


namespace Step90IncomeComparisoon
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            
            Console.WriteLine("Person 1");
            Console.WriteLine("What is the hourly pay rate of Person 1?");
            decimal Person1Rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours per week does Person 1 work?");
            short Person1Hours = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("What is the hourly pay rate of Person 2?");
            decimal Person2Rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("How many hours per week does Person 2 work?");
            short Person2Hours = Convert.ToInt16(Console.ReadLine());

            decimal Person1Salary = Person1Rate * Person1Hours * 52;
            decimal Person2Salary = Person2Rate * Person2Hours * 52;

            Console.WriteLine("The anual salary of Person 1 is " + Convert.ToString(Person1Salary));
            Console.WriteLine("The anual salary of Person 2 is " + Convert.ToString(Person2Salary));
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(Convert.ToString(Person1Salary > Person2Salary));

            Console.Read();
        }
    }
}

//REQUIREMENTS:

//- The program must start by printing “Anonymous Income Comparison Program” to the screen.

//- It must then print “Person 1” to the screen and get the following details:

//Hourly Rate

//Hours worked per week

//- It must then print “Person 2” to the screen and then get the following details:

//Hourly rate

//Hours worked per week

//- It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.

//- It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.

//- It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.