using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Step210IOStream
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamFun();
        }
        public static void StreamFun()
        {
            Console.WriteLine("What number would you like to log?");
            string userInput = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(@"C:\DeleteThisFolder\log.txt", true))
            {
                sw.WriteLine(userInput);
            }

            using (StreamReader sr = new StreamReader(@"C:\DeleteThisFolder\log.txt"))
            {
                Console.WriteLine("\nThe following numbers are found in log.txt:");
                string s;
                do
                {
                    s = sr.ReadLine();
                    Console.WriteLine(s);
                } while (s != null);
            }
            StreamFun();
        }
    }
}
