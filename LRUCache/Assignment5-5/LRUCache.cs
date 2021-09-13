using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_5
{

    public class Node
    {
        public int key;
        public int val;
        public Node next;
        public Node prev;
        public Node(int k,int v)
        {
            this.key = k;
            this.val = v;
            this.next = null;
            this.prev = null;
        }
       
    } 
    
   public class LRUCache
    {
       public Node head ,tail;
       public int count { get; set; }
       public int capacity { get; set; }

       Dictionary<int, Node> page_key = new Dictionary<int, Node>();

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            count = 0;

        }
       
        public void insert_node(Node node)
        {
            if (head == null)
            {             
                head = node;
                tail = node;
                head.next = null;
                head.prev = null;
                tail.prev = null;
                tail.next = null;
                page_key[node.key] = node;
                count++;
            }
            else
            {              
                node.prev = tail;
                tail.next = node;            
                node.next = null;
                tail = node;
                page_key[node.key] = node;
                count++;
            }


        }
        public void set(int key,int val)
        {
            Node n = new Node(key, val);
            Node temp;
            if (page_key.ContainsKey(key))
            {
                n = page_key[key];

                shift_node(n);

            }
            else if (count == capacity)
            {
                deletenode();
                insert_node(n);
            }
            else
            {
                insert_node(n);
            }
                       
                  

            temp = head;
            Console.WriteLine("Values in Cache"+count);
            while(temp!=null)
            {
                Console.Write(temp.val+" ");
                temp = temp.next;
            }
            Console.WriteLine();

        }

        public void shift_node(Node n)
        {
           if(n!=tail && n!=head)
            {
                n.prev.next = n.next;
                n.next.prev = n.prev;
                count--;
                insert_node(n);
                         
            }
           else if(n==head)
            {
                deletenode();
                insert_node(n);
            }
          
            
 
            
        }

        public void deletenode()
        {
            Node temp;
            temp = head;
            head = temp.next;
            head.prev = null;           
            page_key.Remove(temp.key);
            temp = null;
            count--;
          
        }

        public int get_val(int key)
        {
            if(page_key.ContainsKey(key))
            {
                return page_key[key].val;
            }
            else
            {
                return -1;
            }
        }
       
    }
}
