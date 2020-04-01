using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step142ListsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a one-dimensional Array of strings. Ask the user to input some text. 
            //   Create a loop that goes through each string in the Array, adding the user’s text to the string. 
            //   Then create a loop that prints off each string in the Array on a separate line.
            Console.WriteLine("Drill 1\n");

            string[] myStrings1 = { "Hello, ", "Hiya, ", "Good morning, ", "What's up, " };
            Console.WriteLine("Enter some text to add to a greeting.");
            string userInputString = Console.ReadLine();
            for (int i = 0; i < myStrings1.Length; i++)
            {
               
                myStrings1[i] = myStrings1[i] + userInputString;
                Console.WriteLine(myStrings1[i]);
            }

            // 2. Create an infinite loop.
            Console.WriteLine("\n\nDrill 2\n");
            Console.WriteLine("Uncomment the code below to create an infinite loop!");
            //while (1 == 1)
            //{
            //    Console.WriteLine("AHhhhhhhh!!! Make it stopppp!!!");
            //}

            // 3. Fix the infinite loop so it will execute.
            Console.WriteLine("\n\nDrill 3\n");
            int whileNum = 10;
            while (whileNum != 1)
            {
                whileNum--;
                Console.WriteLine(whileNum);
            }

            // 4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            Console.WriteLine("\n\nDrill 4\n");
            int plus3 = 3;
            while (plus3 < 27)
            {
                plus3 = plus3 + 3;
                Console.WriteLine(plus3);
            }

            //5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            Console.WriteLine("\n\nDrill 5\n");
            int orEqual = 3;
            while (orEqual <= 27)
            {
                orEqual = orEqual + 3;
                Console.WriteLine(orEqual);
            }

            //6. Create a List of strings where each item in the list is unique.
            //   Ask the user to input text to search for in the List. 
            //7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //8. Add code to that above loop that stops it from executing once a match has been found.
            Console.WriteLine("\n\nDrill 6, 7, and 8\n");

            List<string> rainbow = new List<string>() { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            Console.Write("Type the name of a color to see if it exists in this list: ");
            string userColor = Console.ReadLine().ToLower();

            while (!rainbow.Contains(userColor))
            {
                Console.WriteLine($"Sorry, but {userColor} is not on our list.");
                Console.Write("Type the name of a color to see if it exists in this list: ");
                userColor = Console.ReadLine().ToLower();
            }

            foreach (string color in rainbow)
            {
                if (color == userColor)
                {
                    Console.WriteLine($"Nice! We do have {color} in our list!");
                    break;
                }
            }

            //9. Create a List of strings that has at least two identical strings in the List. 
            //   Ask the user to select text to search for in the List. 
            //   Create a loop that iterates through the loop and then displays the indices of 
            //   the array that contain matching text on the screen.
            //10. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            Console.WriteLine("\n\nDrill 9 and 10");

            List<string> favFoodSurv = new List<string>() { "pizza", "hamburger", "pasta", "candy", "pizza" };

            Console.Write("Type in Pizza or another food to see how many people listed it as their favorite food: ");
            string userFood = Console.ReadLine().ToLower();

            while (!favFoodSurv.Contains(userFood))
            {
                Console.WriteLine($"Sorry, {userFood} is not on our list. Try pizza, hambuger, pasta, or candy.");
                userFood = Console.ReadLine().ToLower();
            }

            for (int i = 0; i < favFoodSurv.Count; i++)
            {
                if (favFoodSurv[i] == userFood)
                {
                    Console.WriteLine($"The food {userFood}, is mentioned at this index: {i}.");
                }
            }

            //11. Create a List of strings that has at least two identical strings in the List. 
            //    Create a foreach loop that evaluates each item in the list, and displays a 
            //    message showing the string and whether or not it has already appeared in the list.
            Console.WriteLine("\n\nDrill 11\n");

            List<string> sportsBalls = new List<string>() 
            { "soccerball", "football", "baseball", "basketball", "softball", "football", "baseball", 
            "frisbee", "basketball", "kickball", "raquetball", "basketball"};

            List<string> sports2 = new List<string>();

            foreach (string ball in sportsBalls)
            {
                if (sports2.Contains(ball))
                {
                    Console.WriteLine($"Hey look, another {ball}!");
                }
                if (!sports2.Contains(ball))
                {
                    sports2.Add(ball);
                    Console.WriteLine($"You found a {ball} in the garage!");
                }
            }

            Console.Read();
        }
    }
}

//1. Create a one-dimensional Array of strings. Ask the user to input some text. 
//   Create a loop that goes through each string in the Array, adding the user’s text to the string. 
//   Then create a loop that prints off each string in the Array on a separate line.
//2. Create an infinite loop.
//3. Fix the infinite loop so it will execute.
//4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
//5. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
//6. Create a List of strings where each item in the list is unique.Ask the user to input text to search for in the List. 
//   Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.
//7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
//8. Add code to that above loop that stops it from executing once a match has been found.
//9. Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List. 
//   Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
//10. Add code to that above loop that tells a user if they put in text that isn’t in the List.
//11. Create a List of strings that has at least two identical strings in the List. 
//    Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.