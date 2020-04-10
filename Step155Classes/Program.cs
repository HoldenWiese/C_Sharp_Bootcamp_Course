using System;


namespace Step155Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number divisible by 5 that you want to perform some math operations on.");
            int result = Convert.ToInt32(Console.ReadLine());

            //Instantiating the MathOps class to use a non-static method.
            MathOps instance = new MathOps();

            int add = MathOps.Add5(result);
            int mult = MathOps.Multiply5(result);
            int div = instance.Divide5(result);

            Console.WriteLine($"{result} plus 5 equals {add}. {result} multiplied by 5 equals {mult}. " +
                $"{result} divided by 5 equals {div}.");
        }
    }
}
