
/*The task is to design and implement methods of an LRU cache.The class has two methods get and set which are defined as follows.
get(x)   : Gets the value of the key x if the key exists in the cache otherwise returns -1
set(x, y) : inserts the value if the key x is not already present.If the cache reaches its capacity it should invalidate the least recently used item before inserting the new item.
In the constructor of the class the size of the cache should be initialized.*/

using System;

namespace Assignment5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCache l = new LRUCache(4);
            
            l.set(8, 3);
            l.set(5, 7);
            l.set(23, 24);
            l.set(9, 5);
            l.set(28, 23);
            
            l.set(9, 5);
            l.set(23, 24);
            l.set(5, 7);
            
            l.set(5, 7);
            l.set(23, 24);

            Console.WriteLine("getval"+l.get_val(3));
        }

    }
}
