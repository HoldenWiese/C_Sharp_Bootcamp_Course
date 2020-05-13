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
                Console.WriteLine("How old are you?");
                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age < 1)
                    {
                        throw new TooYoungException("You are too young to use a computer.");
                        //This message only shows if error is not caught.
                    }
                    validInput = true;
                    DateTime myDateTime = new DateTime();
                    myDateTime = DateTime.Now;
                    int year = myDateTime.Year;
                    Console.WriteLine($"Depending on your birthday, you were born in {year-age} or {year-age-1}.");
                }
                catch (TooYoungException)
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
    public class TooYoungException : Exception
    {
        public TooYoungException()
            : base() { }
        public TooYoungException(string message)
            : base(message) { }
    }
}

//1. Ask the user for their age.
//2. Display the year the user was born.
//3. Exceptions must be handled using "try .. catch".
//4. Display appropriate error messages if the user enters zero or negative numbers.
//5. Display a general message if an exception was caused by anything else.