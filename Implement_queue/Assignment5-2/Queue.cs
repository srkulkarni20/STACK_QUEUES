using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Assignment5_2
{
    public class Queue
    {
        public stack s2 = new stack();
        public stack s1 = new stack();



        public void enqueue(int ele) //o(1)
        {
            if (s1.stack_full())
            {
                s1.Push(ele);
            }
            else
            {
                s1.Push(ele);
            }
        }

        public int dequeue()  //o(n)
        {

            if (s1.stack_empty() && s2.stack_empty())
            {
                Console.WriteLine("Queue is Empty");
                return 0;
            }
            if (s2.stack_empty())
            {
                while (!(s1.stack_empty()))
                {
                    int ele = s1.Pop();
                    if (s2.stack_full())
                    {
                        s2.Push(ele);
                    }
                    else
                    {
                        s2.Push(ele);
                    }
                }
            }

                return (s2.arr[s2.top--]);
            }
        
    }
}
