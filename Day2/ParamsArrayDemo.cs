using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class ParamsArrayDemo
    {
        static void Main()
        {
            int sum = 0;
            sum = Add(1, 2);
            Console.WriteLine(sum);
            sum = Add(1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine(sum);
            sum = Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 54, 54, 5, 45, 4, 5, 4, 54, 5, 4, 5, 45, 4, 5, 4, 5, 45, 4, 5);
            Console.WriteLine(sum);

        }
        static int Add(params int[] num)
        {
            int sum = 0;
            foreach (int temp in num)
                sum += temp;
            return sum;
        }
        //static void Add(int x , int y)
        //{
        //    Console.WriteLine(x + y) ;
        //}
        //static void Add(int x, int y, int z)
        //{
        //    Console.WriteLine(x + y + z);
        //}

    }
}
