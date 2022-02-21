using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class OutputPara
    {
        static void Main()
        {
            int Add, Subtract, Prod, Divide;
            Operations(20, 10, out Add, out Subtract, out Prod, out Divide)
 ;
            Console.WriteLine("Result of Addition "+ Add);
            Console.WriteLine("Result of Subtraction " + Subtract);
            Console.WriteLine("Result of Product " + Prod);
            Console.WriteLine("Result of Divison " + Divide);

        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract (int x, int y)
        { 
            return x - y;
        }
        static void Operations (int x, int y , out int Add, out int Subtract,
            out int Prod, out int Divide)
        {
            Add= x + y;
            Subtract = x - y;
            Prod = x * y;
            Divide = x / y;

        }
    }
}
