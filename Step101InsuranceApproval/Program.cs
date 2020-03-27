using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step101InsuranceApproval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How old are you?");
            sbyte Age = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? True or False?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            short Tickets = Convert.ToInt16(Console.ReadLine());

            if (Age > 15 && DUI == false && Tickets < 4)
            {
                Console.WriteLine("You qualify for our car insurance!");
            }
            else
            {
                Console.WriteLine("You do not qualify for our car insurance.");
            }
            Console.Read();
        }
    }
}

//REQUIREMENTS
//Ask the following questions:
//What is your age?
//Have you ever had a DUI?
//How many speeding tickets do you have?
//Use the following qualification rules to determine if the applicant qualifies for car insurance:
//Applicants must be over 15 years old.
//Applicants must not have any DUI’s.
//Applicants must not have more than 3 speeding tickets.
//Print the result of the boolean expression created from the above business rules.