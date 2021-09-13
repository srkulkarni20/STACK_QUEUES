/*Given an input stream of n characters consisting only of 
small case alphabets the task is to find the first non repeating character each time a character is inserted 
to the stream.If no non repeating element is found print -1.*/


using System;

namespace Assignment5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamProcess s = new StreamProcess();
            s.process_stream("aaadbcdcc");
        }
    }
}
