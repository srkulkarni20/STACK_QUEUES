using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_3
{
    public class Queue
    {
        public Nullable<int>[] arr = new Nullable<int>[5];
        public int head { get; set; }
        public int tail { get; set; }
        public int count { get; set; }



        public Queue()
        {
            head = 0;
            tail = 0;
            count = 0;
        }



        public void enqueue(int ele)
        {
            if (count == arr.Length)
            {
                increase_capacity();
            }
            arr[tail] = ele;
            tail = (tail + 1) % arr.Length;
            count++;


        }

        public void increase_capacity()
        {
            int firstPart, numToCopy = count;
            Nullable<int>[] new_arr = new Nullable<int>[arr.Length * 2];
            if (count > 0)
            {
                if (head < tail)
                {
                    Array.Copy(arr, head, new_arr, 0, count);
                }
                else
                {
                    firstPart = (arr.Length - head < numToCopy) ? arr.Length - head : numToCopy;
                    Array.Copy(arr, head, new_arr, 0, firstPart);
                    numToCopy -= firstPart;
                    Array.Copy(arr, 0, new_arr, firstPart, numToCopy);
                }

                arr = new_arr;
                tail = count;
                head = 0;

            }

        }

        public int dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Nullable<int> removed = arr[head];
                arr[head] = null;
                head = (head + 1) % arr.Length;
                count--;
                return (int)removed;

            }

         

        }

        public bool queue_empty()
        {
            if(count==0)
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
