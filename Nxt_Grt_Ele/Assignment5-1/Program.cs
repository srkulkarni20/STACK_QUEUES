
//Given an array, print the Next Greater Element (NGE) for every element. 
//The Next greater Element for an element x is the first greater element on the right side of x in array. Elements for which no greater element exist, consider next greater element as -1
using System;

namespace Assignment5_1
{
    class Program
    {

        static public void Find_next_gen(int[] a, int n)
        {
            int i = 0, count = 0, large = a[i], large_index = i; ;
            bool found = false;

            int[] b = new int[n];
            for (i = 0; i < n; i++)
            {

                
                if (a[i] > large)
                {
                    large = a[i];
                    large_index = i;
                    found = true;
                }
                if(i>large_index)
                {
                    large = a[i];
                }
                if (a[i] < large)
                {
                    b[i] = large;
                }
                else
                {
                    b[i] = -1;
                    count++;
                }
                int k = i - 1;
                while (count >1  && found == true)
                {
                    if (a[k] < large)
                    {
                        b[k] = large;
                    }
                    k--;
                    count--;
                }
                found = false;
               
            }

            for (i = 0; i < n; i++)
            {
                Console.Write(" " + b[i]);
            }
        }
        static void Main(string[] args)
        {
            string val = Console.ReadLine();
            int n = Convert.ToInt32(val);
            int[] array = new int[10000];
            string[] num = Console.ReadLine().Split();
            int j = 0;
            for (j = 0; j < n; j++)
            {
                array[j] = Convert.ToInt32(num[j]);
            }
            Find_next_gen(array, n);
        }
    }
}
