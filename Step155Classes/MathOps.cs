﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Step155Classes
{
    class MathOps
    {
        public static int Add5(int user_input)
        {
            int sum = user_input + 5;
            return sum;
        }

        public static int Multiply5(int user_input)
        {
            int product = user_input * 5;
            return product;
        }

        public int Divide5(int user_input)
        {
            int quotient = user_input / 5;
            return quotient;
        }
    }
}


//1. Create a class. In that class, create three methods, each of which will take one integer parameter
// in and return an integer.The methods should do some math operation on the received parameter.
// Put this class in a separate.cs file in the application.
//2. In the Main() program, ask the user what number they want to do the math operations on.
//3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.