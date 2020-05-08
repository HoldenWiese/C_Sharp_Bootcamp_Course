using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step225ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("What year were you born?");
                try
                {
                    int birthYear = Convert.ToInt32(Console.ReadLine());
                    if (birthYear < 1)
                    {
                        throw new TooOldException("You are too old to be alive.");
                        //This message only shows if error is not caught.
                    }
                    validInput = true;
                    Console.WriteLine($"You were born in {birthYear}");
                }
                catch (TooOldException)
                {
                    Console.WriteLine("Hmm.. I don't believe you. Try again.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Only type digits please. No decimals or letters.");
                } 
            }

            Console.Read();
        }
    }
    public class TooOldException : Exception
    {
        public TooOldException()
            : base() { }
        public TooOldException(string message)
            : base(message) { }
    }
}

//1. Ask the user for their age.
//2. Display the year the user was born.
//3. Exceptions must be handled using "try .. catch".
//4. Display appropriate error messages if the user enters zero or negative numbers.
//5. Display a general message if an exception was caused by anything else.