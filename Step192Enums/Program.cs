using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step192Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userAttempt = true;
            while (userAttempt)
            {
                try
                {
                    Console.WriteLine("What day is it today?");
                    string userInput = Console.ReadLine();
                    Enum.TryParse(userInput, out DaysOfTheWeek userDay);
                    if (userInput == userDay.ToString())
                    {
                        userAttempt = false;
                        Console.WriteLine($"According to you the day is {userDay}.");
                    }
                    else
                    {
                        throw new System.ArgumentException();
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Please try again. Enter Monday, Tuesday, Wednesday," +
                                      "Thursday, Friday, Saturday, or Sunday.");
                }

            }

            Console.Read();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}

//1. Create an enum for the days of the week.
//2. Prompt the user to enter the current day of the week.
//3. Assign the value to a variable of that enum data type you just created.
//4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." 
//    to the console if an error occurs.
//Note - In the last video, we explained the underlying concepts behinds enums.
//    Nobody knows everything about a programming language and its features, 
//    so it's our job as programmers to do research on how to work with various data types, 
//    classes and libraries. For this drill, you'll need to do some additional research on how to parse enums.