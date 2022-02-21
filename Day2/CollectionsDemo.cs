using System;
using System.Collections;

namespace Day2
{
    class CollectionsDemo
    {
        static void Main(string[] args)
        {
            //int? x = null;

            // int [] num = new     int[10];
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
           
            list.Add("Hello");
            list.Add(90.5f);


            //for(int i=0; i<list.Count; i++)
            //    Console.WriteLine(list[i]);

            // foreach loop
            foreach(var temp in list)
                Console.WriteLine(temp);

            list.Add(100);
            list.Insert(1, 200);
            Console.WriteLine("After inssrtion in list");
            foreach(int temp in list)
                Console.WriteLine(temp);

            list.Remove(100);
            list.RemoveAt(2);

            Console.WriteLine("After deletion in list");
            foreach (var temp in list)
                Console.WriteLine(temp);

            // Stack follows LIFO > Last In First out
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            stack.Push("hello");
            Console.WriteLine("STACK");
            foreach(var temp in stack)
                Console.WriteLine(temp);


            stack.Pop();
            Console.WriteLine("After Deletion from STACK");
            foreach (int temp in stack)
                Console.WriteLine(temp);


            // FIFO > First in First Out
            Queue queue = new Queue();
            queue.Enqueue(1000);
            queue.Enqueue(2000);
            queue.Enqueue(3000);
            Console.WriteLine("QUEUE");
            foreach(int temp in queue)
                Console.WriteLine(temp);
            queue.Dequeue();
            Console.WriteLine("After deletion in QUEUE");
            foreach (int temp in queue)
                Console.WriteLine(temp);

            Hashtable ht = new Hashtable();
            ht[1] = 90;
            ht[2] = 98;
            ht[3] = 87;
            ht["Deepak"] = 90;
            // Directly search some value
            Console.WriteLine(ht[2]);
            Console.WriteLine("HashTable");
            foreach(int temp in ht.Keys)
                Console.WriteLine("Marsk of RollNo " + temp  + " are " + ht[temp]);






        }
    }
}
