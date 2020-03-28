using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step126WhileAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What vegetable am I thinking of?");
            string vegetable = Console.ReadLine();
            bool correct = vegetable == "Potato";

            do
            {
                switch (vegetable)
                {
                    case "Apple":
                        Console.WriteLine("That is not a vegatable! Please try again?");
                        vegetable = Console.ReadLine();
                        break;
                    case "Cucumber":
                        Console.WriteLine("WRONG! Try again.");
                        vegetable = Console.ReadLine();
                        break;
                    case "Celery":
                        Console.WriteLine("An excellent veggie, but not the one I'm thinking of. Try again please.");
                        vegetable = Console.ReadLine();
                        break;
                    case "Potato":
                        Console.WriteLine("You got it! I got fries on my mind.");
                        correct = true;
                        break;
                    default:
                        Console.WriteLine("Not quite. Please guess again.");
                        vegetable = Console.ReadLine();
                        break;
                }
            }
            while (!correct);



            // Just a plain while loop.
            int guess = 1;

            while (guess != 7)
            {
                Console.WriteLine("Guess the correct number between 0 and 10.");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == 7)
                {
                    Console.WriteLine("Congrats! You guessed it!");
                }
            }

            Console.Read();
        }
    }
}
