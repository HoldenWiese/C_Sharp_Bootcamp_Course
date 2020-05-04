using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step221VarConstConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNum = 10;
            const int myNum2 = 15;
            Console.WriteLine($"My var is {myNum}.\nMy const is {myNum2}");

            Addition myAddition = new Addition(1, 2);
            Addition myAddition2 = new Addition(1);

            Console.WriteLine(myAddition.AddMyNums());
            Console.WriteLine(myAddition2.AddMyNums());

            Console.ReadLine();
        }
    }
    class Addition
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public Addition(int first, int second)
        {
            num1 = first;
            num2 = second;
        }
        public Addition(int first) : this(first, 5)
        {

        }

        public int AddMyNums()
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
//1. Create a const variable.
//2. Create a variable using the keyword "var".
//3. Chain two constructors together.
