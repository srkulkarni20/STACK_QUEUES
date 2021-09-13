//Implement a Queue using 2 stackss1 and s2.
using System;

namespace Assignment5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.s1.top = -1;
            q.s2.top = -1; ;
            q.enqueue(4);
            q.enqueue(5);
            q.enqueue(6);
            q.enqueue(8);
            int ele = q.dequeue();
            Console.WriteLine(ele);
            ele = q.dequeue();
            Console.WriteLine(ele);
            ele = q.dequeue();
            Console.WriteLine(ele);
            ele = q.dequeue();
            Console.WriteLine(ele);
            ele = q.dequeue();
            Console.WriteLine(ele);

        }

    }
}
