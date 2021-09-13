
//Implement a Stack in which you can get min element in O(1) time and O(1) space.

using System;

namespace Assignment5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.top = -1;
            s.Push(3);
            s.Push(7);
            s.Push(6);
            s.Push(2);
            s.Pop();


            s.get_min();


        }
    }
}
