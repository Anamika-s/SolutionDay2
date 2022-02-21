using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class GenericCollections
    {
        static void Main()
        {   // ArrayList
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(2);

            foreach(int temp in list)
                Console.WriteLine(temp);

            Stack<string> stack = new Stack<string>();
            stack.Push("Ajay");
            stack.Push("Jatin");

           foreach(string temp in stack)
                Console.WriteLine(temp);

            Queue<float> queue = new Queue<float>();
            queue.Enqueue(190.9f);

            Dictionary<string, int> records = new Dictionary<string, int>();
            records["Ajay"] = 90;
            records["Deepak"] = 989;




        }
    }
}
