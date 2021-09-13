//Implement a Stack using 2 queueq1 and q2 
using System;

namespace Assignment5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Queue q = new Queue();
            q.enqueue(3);
            q.enqueue(4);
            q.enqueue(5);
            q.enqueue(6);
            q.enqueue(7);
           
            q.enqueue(5);            
            
            
            q.enqueue(9);
            q.enqueue(8);
            q.enqueue(4);
            Console.WriteLine(q.head);
            Console.WriteLine(q.tail);*/

            stack s = new stack();
            s.push(4);
            s.push(5);
            s.push(6);
            s.push(7);
            s.push(8);
            Console.WriteLine(s.pop());
            s.push(9);
            Console.WriteLine(s.pop());
        }
    
    }
}
