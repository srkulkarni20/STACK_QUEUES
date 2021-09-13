using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_3
{
    public class stack
    {
       public Queue q1 = new Queue();
       public Queue q2 = new Queue();


       public void push(int ele)
        {
            q1.enqueue(ele);
        }

      public int pop()
        {
            int ele;
            if(q1.queue_empty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                while(q1.count>1)
                {
                 ele = q1.dequeue();
                 q2.enqueue((int)ele);
                }
                ele = q1.dequeue();
                Queue temp = q1;
                q1 = q2;
                q2 = temp;
                return ele;
            }

        }
    }
}
