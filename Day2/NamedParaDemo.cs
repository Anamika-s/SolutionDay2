using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class NamedParaDemo
    {
        static void Main()
        {
            // Named Parameter
            Display(name: "Deepak", marks: 90, rn: 1, address: "Delhi");

        }
        static void Display(int rn, string name, string address, int marks)
        {
            Console.WriteLine("RollNo is " + rn);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Address is " + address);
            Console.WriteLine("Marks are " + marks);
        }
    }
}
