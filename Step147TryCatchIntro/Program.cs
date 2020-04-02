using System;
using System.Collections.Generic;

namespace Step147TryCatchIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a list of integers. 
            //   Ask the user for a number to divide each number in the list by.
            //   Write a loop that takes each integer in the list, 
            //   divides it by the number the user entered, and displays the result to the screen.
            //2. Run that code, entering in non-zero numbers as the user.Look at the displayed results.
            //3. Run that code, entering in zero as the number to divide by.Note any error messages you get.
            //4. Run that code, entering in a string as the number to divide by.Note any error messages you get.
            //5. Now put the loop in a try/catch block.
            //   Below and outside of the try/catch block, make the program print a message to the display to let you
            //   know the program has emerged from the try/catch block and continued on with program execution.
            //   In the catch block, display the error message to the screen. 
            //   Then try various combinations of user input: valid numbers, zero and a string. 
            //   Ensure the proper error messages display on the screen, 
            //   and that the code after the try/catch block gets executed.

            Console.WriteLine("Step 147 Utilizing Try/Catch statements.\n\nRequirement 1.\n");
            
            List<int> myInts = new List<int>()
            {
                5,
                10,
                15,
                20
            };

            try
            {
                Console.Write("Here is a list of numbers I created: ");

                for (int i = 0; i < myInts.Count; i++)
                {
                    Console.Write(myInts[i] + " ");
                }

                Console.WriteLine("\nWhat number would you like to divide each number in the list by? ");
                
            int response1 = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < myInts.Count; i++)
                {
                    Console.WriteLine(myInts[i] + " divided by " + response1 + " equals: " + myInts[i] / response1);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This code comes from using a finally statemnet.");
            }

            Console.WriteLine("\nThe program has emerged from the try/catch blocks!");
        }
    }
}