using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step160OptionalMethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            double response1;
            double response2 = 0;

            BagCosts Total = new BagCosts();

            Console.WriteLine("Step 160. Creating a method with an optional parameter.\n");

            Console.WriteLine("How many pounds does your heaviest bag weigh?");
            response1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many pounds does your second bag weigh? Press enter to skip this question if you" +
                "do not have a second bag.");
            try
            {
                response2 = Convert.ToDouble(Console.ReadLine());
            } 
            catch (Exception) { }

            Console.WriteLine("The total cost for your baggage will be {0} dollars.", Total.TotalPrice(response1, response2));

            Console.ReadLine();
        }
    }
}

//1. Create a class. In that class, create a method that takes two integers as parameters.Make one of them optional.
//   Have the method do a math operation and return an integer result.
//2. In the Main() method of the console app, instantiate the class.
//3. Ask the user to input two numbers, one at a time.Let them know they need not enter anything for the second number.
//4. Call the method in the class, passing in the one or two numbers entered.
//5. Try various combinations of numbers on the code, including having no second number.