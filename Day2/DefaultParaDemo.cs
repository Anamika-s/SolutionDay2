using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class DefaultParaDemo
    {  static void Main()
        {
            SI(12000, 2, 3);
            SI(10000, 2);

            SI(15000);
        }
        // Default / Optional Parameter
        static void SI(int P, int R = 3, int T = 2)
        {
            Console.WriteLine((P * R * T) / 100);
        }
    }
}
