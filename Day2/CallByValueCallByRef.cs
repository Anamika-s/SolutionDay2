using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class CallByValueCallByRef
    {
        static void Main()
        {

            int x = 10;
            Console.WriteLine("Value of x before Calling Change1 ");
            Console.WriteLine(x);
            Change1(x);
            Console.WriteLine("Value of x after Calling Change1 " + x);
            Change2(ref x);
            Console.WriteLine("Value of x after Calling Change1 " + x);
          
           int flag = Search(10);
            if(flag==1)
                Console.WriteLine("Found");
            else
                Console.WriteLine("Not found");
           

        }

        static void Change1(int x)
        {
            x = 100;
            Console.WriteLine("Value of x in Change1 is " + x);
        }

        static void Change2(ref int x)
        {
            x = 200;
            Console.WriteLine("Value of x in Change2 is " + x);

        }


      

       

       

        static int Search(int x)
        {
            List<int> list = new List<int>() { 1, 2, 3, 45 };
            int flag = 0;
            foreach (int temp in list)
            {
                if (temp == x)
                {
                    flag = 1;
                    break;
                }
            }
            return flag;
        }
       

    }
}
