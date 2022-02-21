using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class MethodOverloadingDemo
    {
        static void  Main()
        {
            Add(10, 90);
            Add(1, 2, 3);
        }
        //static void Add1(int x, int y)
        //{
        //    Console.WriteLine(x+y);
        //}
        //static void Add2(int x, int y , int z)
        //{
        //    Console.WriteLine(x+y+z);
        //}
        //static void Add3(int a, int b, float c)
        //{
        //    Console.WriteLine(a+b+c);
        //}

        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        static void Add(int a, int b, float c)
        {
            Console.WriteLine(a + b + c);
        }
    }
}
