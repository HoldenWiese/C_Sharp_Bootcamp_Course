using System;
using System.Globalization;

namespace Step123ShippingQuote
{
    class Program
    {
        static void Main()
        {
            double weight;
            double width;
            double height;
            double length;
            double dimensionsSum;
            decimal quote;
            string specifier;

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How many pounds does the package weigh?");
            weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                Environment.Exit(0);
            }

            Console.WriteLine("What is the width of the package?");
            width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the height of the package?");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the length of the package?");
            length = Convert.ToDouble(Console.ReadLine());

            dimensionsSum = width + height + length;

            if (dimensionsSum > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Good bye.");
                Console.Read();
                Environment.Exit(0);
            }

            // 
            quote = Convert.ToDecimal(weight * width * height * length / 100);
            specifier = "C";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

            Console.WriteLine("It is going to cost {0}. Show me the money!", quote.ToString(specifier, culture));

            Console.Read();
        }
    }
}

//REQUIREMENTS
//The first line of the program must be: “Welcome to Package Express.Please follow the instructions below.”
//The user must then be prompted for the package weight.
//If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express.Have a good day.” At this point the program would end.
//The user must then be prompted for the package width.
//Then the package height.
//Then the package length.
//If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
//The dimensions are then multiplied together with the weight and then divided by 100.
//The result of that calculation is the quote.
//Display the quote to the user as a dollar amount.