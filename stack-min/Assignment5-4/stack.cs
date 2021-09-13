using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_4
{
    public class Stack
    {
        public int[] arr = new int[2];
        public int top { get; set; }
        public int minEle { get; set;}

        public Stack()
        { 
            top = -1;
        }
        public void Push(int x)
        {
            int ele;
           
            if (stack_empty())
            {
                minEle = x;
                top++;
                arr[top] = x;
            }
            else
            {
                
                
                if (x < minEle)
                {
                    ele=(2 * x - minEle);
                    minEle = x;
                }
                else
                {
                    ele = x;
                }

                if(stack_full())
                {
                    top++;
                    arr[top] = ele;
                }
                else
                {
                    top++;
                    arr[top] = ele ;

                }
            }


        }

        public void Pop()
        {

            if (stack_empty())
            {
                Console.WriteLine("stack is empty");
                return;

            }

            int ele = arr[top--];

            if (ele < minEle)
            {
                minEle = 2 * minEle - ele;

            }



        }

        public void get_min()
        {
            if (stack_empty())
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                Console.WriteLine("The minimum Element in stack : " + minEle);
            }

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
            Console.WriteLine("in increase-size" + top);



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

