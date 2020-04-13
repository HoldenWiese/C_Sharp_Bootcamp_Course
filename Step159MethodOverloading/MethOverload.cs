using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Step159MethodOverloading
{
    class MethOverload
    {
        public static int MathFun(int userInput)
        {
            int result = userInput + 5;
            return result;
        }

        public static int MathFun(decimal num)
        {
            int result = Convert.ToInt32(num * 5);
            return result;
        }

        public static int MathFun(string num)
        {
            int result = 0;
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    Console.WriteLine("Write a number you'd like to multiply by 2.");
                    string userInput = Console.ReadLine();
                    result = Convert.ToInt32(userInput) * 2;
                    tryAgain = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("There was an error converting your input to a number. Ensure you write a numeral.\n");
                }
            }
            return result;
        }
    }
}
