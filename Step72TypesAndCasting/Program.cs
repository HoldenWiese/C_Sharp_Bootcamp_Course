using System;


namespace Step72TypesAndCasting
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Studen Daily Report");

            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();

            Console.WriteLine("What page number?");
            int Page = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            bool Needs = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Were there any positive experiences you'd like you share? Please give specifics.");
            string PositivieExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string OtherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            sbyte Hours = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.Read();
        }
    }
}
