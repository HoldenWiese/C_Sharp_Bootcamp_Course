using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step164OutputParamsAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the class
            DivideByTwo Calculate = new DivideByTwo();

            //Get user input
            Console.Write("Type a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First the number will be divided by 2 using a method from an instantiated class.\n" +
                              "Then a static method will calculate result of adding 5 and subtracting 5.\n" +
                              "Then there is an example of method overloading using a string as a paramet instead of a int.\n");

            //Divide by 2 method
            Calculate.Divide(out int myResult, userInput);

            //Two outputs method and static class 
            AddAndSubtract.SumAndDiff(out int sum, out int diff, userInput);

            //Overload divide method with a string parameter
            Calculate.Divide(out int overload, "12");

            //Output method results to console
            Console.WriteLine($"{userInput} / 2 = {myResult}\n" +
                              $"{userInput} + 5 = {sum}. {userInput} - 5 = {diff}.\n" +
                              $"12 / 2 = {overload}");

            Console.Read();
        }
    }
}

//1. Create a class. In that class, create a void method that outputs an integer.
//   Have the method divide the data passed to it by 2.
//2. In the Main() method, instantiate that class.
//3. Have the user enter a number.Call the method on that number.
//   Display the output to the screen. It should be the entered number, divided by two.
//4. Create a method with output parameters.
//5. Overload a method.
//6. Declare a class to be static.