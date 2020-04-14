using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step161MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum1 = 10;
            int myNum2 = 20;

            Console.WriteLine("Step 161. I'm not sure what this drill demonstrates.\n");
           
            MyMath Fun = new MyMath();

            Fun.WeirdMethod(1, 2);

            Fun.WeirdMethod(num1: myNum1, num2: myNum2);

            Console.Read();
        }

    }
}

//1. Create a class. In that class, create a void method that takes two integers as parameters.
//   Have the method do a math operation on the first integer and display the second integer to the screen.
//2. In the Main() method of the console app, instantiate the class.
//3. Call the method in the class, passing in two numbers.
//4. Call the method in the class, specifying the parameters by name.
