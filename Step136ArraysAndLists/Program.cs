using System;
using System.Collections.Generic;

namespace Step136ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Requirement 1
            //Creating the array.

            //string[] myStringsArray = new string[5];
            //myStringsArray[0] = "I'm number 1!";
            //myStringsArray[1] = "I'm number 2.";
            //myStringsArray[2] = "I'm number 3..";
            //myStringsArray[3] = "I'm number 4...";
            //myStringsArray[4] = "I'm last.....";

            //string[] myStringsArray = new string[5] { "Index 0", "Index 1", "Index 2", "Index 3", "Index 4" };

            string[] myStringsArray = { "Index 0", "Index 1", "Index 2", "Index 3", "Index 4" };

            Console.Write("Write an index number to return the value from my string array! ");
            int firstResponse = Convert.ToInt32(Console.ReadLine());

            //Requirement 3
            while (firstResponse > myStringsArray.Length - 1 || firstResponse < 0)
            {
                Console.Write($"Please enter a number between -1 and {myStringsArray.Length}: ");
                firstResponse = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(myStringsArray[firstResponse]);

            // Requirement 2
            int[] IntegersArray = { 0, 1, 2, 3, 4, 5 };

            Console.Write(String.Format("Input a number greater that -1 and less than {0}: ", IntegersArray.Length));
            int secondResponse = Convert.ToInt32(Console.ReadLine());

            //Requirement 3
            while (secondResponse > IntegersArray.Length - 1 || secondResponse < 0)
            {
                Console.Write(String.Format("Invalid number! Input a number greater that -1 and less than {0}: ", IntegersArray.Length));
                secondResponse = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"The value of the element at that index is {secondResponse}.");

            //Requirement 4
            List<string> myList = new List<string>();
            myList.Add("Hello");
            myList.Add("there.");
            myList.Add("My name");
            myList.Add("is Holden!");

            Console.WriteLine("Please select a number between -1 and 4. If you mess up the program will die!");
            int response3 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"The random text you selected from the list is \"{myList[response3]}\".");

            Console.Read();
        }
    }
}
//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:\
//1. Create a one-dimensional Array of strings.Ask the user to select an index of the Array and then display the string at that index on the screen.
//2. Create a one-dimensional Array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
//3. Add in a message that displays when the user selects an index that doesn’t exist.
//4. Create a List of strings.Ask the user to select an index of the List and then display the content at that index on the screen.