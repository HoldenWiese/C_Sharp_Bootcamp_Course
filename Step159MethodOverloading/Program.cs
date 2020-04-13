using System;

namespace Step159MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Step 159 | Demonstrating method overloading.\n");
            
            Console.WriteLine("Write any int number to increase by 5.");
            int userSays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MethOverload.MathFun(userSays));

            Console.WriteLine("Write any decimal number you want to multiply by 5. " +
                "The result will be rounded to nearest integer.");
            decimal userDecimal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(MethOverload.MathFun(userDecimal));

            Console.WriteLine("The result of the operation is {0}", MethOverload.MathFun("test"));
        }
    }
}

//1. Create a class. In that class, create a method that will take in an integer, 
//   do a math operation to it and then return the answer as an integer.
//2. In the Main() method of the console app, instantiate the class and call the one method, 
//   passing in an integer.Display the result to the screen.
//3. Add a second method to the class, with the same name, that will take in a decimal, 
//   do a different math operation to it and then return the answer as an integer.
//4. In the Main() method of the console app, instantiate the class and call the second method, 
//   passing in a decimal. Display the result to the screen.
//5. Add a third method to the class, with the same name, that will take in a string, 
//   convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.
//6. In the Main() method of the console app, instantiate the class and call the third method, 
//   passing in a string that equates to an integer.Display the result to the screen.