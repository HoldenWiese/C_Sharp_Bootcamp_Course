using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step197Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number wage = new Number() { Amount = 7.25m };
            Console.WriteLine($"Minimum wage is ${wage.Amount}.");
            Console.Read();
        }
        struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
