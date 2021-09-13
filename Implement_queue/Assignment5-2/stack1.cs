using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_2
{
    public class stack
    {
        public int[] arr = new int[2];
        public int top;



        public void Push(int ele)
        {
            top++;
            arr[top] = ele;
        }

        public int Pop()
        {
            return arr[top--];
        }

        public int Peek()
        {
            return arr[top];
        }

        public bool stack_full()
        {
            if (top == arr.Length - 1)
            {
               
                increase_size();
                return true;
            }
            else
            {
                return false;
            }
               
                        
        }

        public void increase_size()
        {
            int[] newarr = new int[arr.Length * 2];
            
            Array.Copy(arr, 0, newarr, 0, arr.Length);
            arr = newarr;
        }
        public bool stack_empty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
