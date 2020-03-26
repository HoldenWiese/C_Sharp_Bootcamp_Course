using System;


namespace Step89MathAndConditions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type in a number to multiply by 50.");
            int Multiply = Convert.ToInt32(Console.ReadLine()) * 50;
            Console.WriteLine(Multiply);

            Console.WriteLine("Type in a number to add 25 to.");
            int Addition = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine(Addition);

            Console.WriteLine("Type in a number to divide by 12.5.");
            double Division = Convert.ToDouble(Console.ReadLine()) / 12.5;
            Console.WriteLine(Division);

            Console.WriteLine("Type a number to check if it is greater than 50.");
            double BooleanNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(BooleanNum > 50);

            Console.WriteLine("Type a number to get the remainder after it is divided by 7.");
            double Modulus = Convert.ToDouble(Console.ReadLine()) % 7;
            Console.WriteLine(Modulus);

            Console.Read();
        }
    }
}


//1. Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).

//2. Takes an input from the user, adds 25 to it, and prints the result to the console.

//3. Takes an input from the user, divides it by 12.5, and prints the result to the console.

//4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.

//5. Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).