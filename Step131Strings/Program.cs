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

            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Welcome to Mad Libs! Let's create a story together!\n");

            Console.WriteLine("Enter a noun that is in outer space: ");
            string spaceNoun = Console.ReadLine();
            Console.WriteLine("\nEnter a very long distance: ");
            string longDistance = Console.ReadLine();
            sb.Append($"Once upon a Time in a(n) {spaceNoun} {longDistance} far away, a brave superhero saved life as we know it.");

            Console.WriteLine("\nEnter an adjective: ");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("\nEnter a color: ");
            string color1 = Console.ReadLine();
            Console.WriteLine("\nEnter a job title: ");
            string jobTitle1 = Console.ReadLine();
            string heroDescription = adjective1 + ", " + color1 + " " + jobTitle1;
            sb.Append($"The {heroDescription} enjoyed helping others.");


            Console.WriteLine("\nEnter an adjective: ");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("\nEnter another adjective: ");
            string adjective3 = Console.ReadLine();
            Console.WriteLine("\nEnter a plural noun: ");
            string pluralNoun = Console.ReadLine();
            Console.WriteLine("\nEnter a type of flying objects: ");
            string flyingObject = Console.ReadLine();

            Console.WriteLine("\nEnter an adjective: ");
            string adjective4 = Console.ReadLine();
            Console.WriteLine("\nEnter a type of cute animals: ");
            string cuteAnimal1 = Console.ReadLine();
            Console.WriteLine("\nEnter an adjective: ");
            string adjective5 = Console.ReadLine();
            Console.WriteLine("\nEnter a type of cute animals: ");
            string cuteAnimal2 = Console.ReadLine();
            sb.Append($"They walked {adjective2}, {adjective3} {pluralNoun} across the street.They prevented {flyingObject} from falling from the sky.They rescued {adjective4} {cuteAnimal1} and {adjective5} {cuteAnimal2}.");

            Console.WriteLine("\nEnter a superhero power: ");
            string superPower1 = Console.ReadLine();
            Console.WriteLine("\nEnter another superhero power: ");
            string superPower2 = Console.ReadLine();
            Console.WriteLine("\nEnter a third superhero power: ");
            string superPower3 = Console.ReadLine();
            sb.Append($"Their superhero powers included {superPower1}, {superPower2}, and {superPower3}.");

            Console.WriteLine("\nEnter an adjective: ");
            string adjective6 = Console.ReadLine();
            Console.WriteLine("\nEnter a noun: ");
            string noun1 = Console.ReadLine();
            Console.WriteLine("\nEnter a color: ");
            string color2 = Console.ReadLine();
            Console.WriteLine("\nEnter an adjective: ");
            string adjective7 = Console.ReadLine();
            Console.WriteLine("\nEnter a noun: ");
            string noun2 = Console.ReadLine();
            string sidekickDescription = (color2 + " " + adjective7 + " " + noun2).ToUpper();
            sb.Append($"One day a giant {adjective6} {noun1} was going to hit the earth.No one knew what to do, but our brave hero and their trusty sidekick, {sidekickDescription}, came to the rescue.");

            Console.WriteLine("\nEnter a past tense verb: ");
            string pastTenseVerb1 = Console.ReadLine();
            Console.WriteLine("\nEnter an adjective: ");
            string adjective8 = Console.ReadLine();
            Console.WriteLine("\nEnter another adjective: ");
            string adjective9 = Console.ReadLine();
            sb.Append($"They {pastTenseVerb1} into their {adjective8}, {adjective9} spaceship and blasted the {noun1} to pieces, saving the day.\n \n THE END.");

            Console.WriteLine("\n Here is your Mad Libs story! Enjoy!\n");
            Console.WriteLine(sb);

            Console.WriteLine("                           _   ");
            Console.WriteLine("                          | | ");
            Console.WriteLine(" ___ _   _ _ __   ___ _ __| |__   ___ _ __ ___ ");
            Console.WriteLine(@"/ __| | | | '_ \ / _ \ '__| '_ \ / _ \ '__/ _ \");
            Console.WriteLine(@"\__ \ |_| | |_) |  __/ |  | | | |  __/ | | (_) |");
            Console.WriteLine(@"|___/\__,_| .__/ \___|_|  |_| |_|\___|_|  \___/ ");
            Console.WriteLine("          | |  ");
            Console.WriteLine("          |_|");
            Console.Read();
        }
    }
}

//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
//1. Concatenate three strings.
//2. Convert a string to uppercase.
//3. Create a Stringbuilder and build a paragraph of text, one sentence at a time.