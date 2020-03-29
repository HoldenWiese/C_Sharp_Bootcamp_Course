using System;
using System.Text;

namespace Step131Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenating variables
            string string1 = "I will ";
            string string2 = "concatenate these ";
            string string3 = "strings together!";
            string concatenate1 = string1 + string2 + string3;
            Console.WriteLine(concatenate1);

            //Concatenating string literals
            Console.WriteLine("\nConcatenation is " + "so much fun" + "!");

            //Converting a string to uppercase
            Console.WriteLine("\n" + concatenate1.ToUpper());

            //Using a string builder to build a paragraph. I think this is what the assignment is asking for?
            StringBuilder mySB = new StringBuilder();
            mySB.AppendLine().Append("This is the first line in my string builder.").AppendLine()
                .Append("Here is another line for my string builder.").AppendLine().Append("This is a nice paragraph!")
                .AppendLine().Append("String builders are awesome!.").Append(string2);

            //Remove data from string to start fresh.
            //mySB.Clear().Append("\nI'm showing new string data without using excess memory.");

            Console.WriteLine(mySB);

            Console.ReadLine();
        }
    }
}

//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Concatenate three strings.
//2. Convert a string to uppercase.
//3. Create a Stringbuilder and build a paragraph of text, one sentence at a time.