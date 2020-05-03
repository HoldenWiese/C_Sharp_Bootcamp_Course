using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step213DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Write a number to see how many hours away from now is.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            DateTime futureDate = DateTime.Now.AddHours(userInput);
            Console.WriteLine(futureDate);

            Console.Read();
        }
    }
}
//1. Prints the current date and time to the console.
//2. Asks the user for a number.
//3. Prints to the console the exact time it will be in X hours, 
//    X being the number the user entered in step 2.

