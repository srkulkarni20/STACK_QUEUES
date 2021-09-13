using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5_6
{

    public class Node
    {
        public char ch { get; set; }
        public Node next;
        public Node prev;
        public Node(char ch)
        {
            this.ch = ch;
            this.next = null;
            this.prev = null;
        }

    }


        public class StreamProcess
        {
            public Node head, tail;
            Dictionary<int, Node> char_addr = new Dictionary<int, Node>();


        public void process_stream(string str)
            {
                char inp_ch;
                for(int i=0;i<str.Length;i++)
                {
                    inp_ch = str[i];
                    if(char_addr.ContainsKey(inp_ch))
                    {
                        if(char_addr[inp_ch]!=null)
                        {
                            remove_node(char_addr[inp_ch]);
                            char_addr[inp_ch] = null;
                            print_nonrepeating();
                        }
                        else
                        {                          
                            print_nonrepeating();
                        }

                    }
                    else
                    {
                        create_node(inp_ch);
                        print_nonrepeating();
                    }
                }

            }

        public void create_node(char inp_ch)
            {
                Node n = new Node(inp_ch);
                if(head==null)
                {
                    head = n;
                    tail = n;
                    head.next = null;
                    head.prev = null;
                    tail.prev = null;
                    tail.next = null;
                    char_addr[inp_ch] = n;
                }
                else
                {
                    n.prev = tail;
                    tail.next = n;
                    n.next = null;
                    tail = n;
                    char_addr[inp_ch] = n;
                    
                }
            }

            public void remove_node(Node n)
            {
               Node temp;
               if (n==head && n==tail)
                {
                  head.next = null;
                  tail = null;
                  head = null;

                }
                else if(n==head)
                {
                    
                    temp = head;
                    head = temp.next;
                    head.prev = null;
                    
                }
                else if(n==tail)
                {
                    
                    temp = tail;
                    tail = temp.prev;
                    tail.next = null;
                   

                }
                else
                {
                    n.prev.next = n.next;
                    n.next.prev = n.prev;
                    
                }
                
            }

            public void print_nonrepeating()
            {
                
                Node n = head;
            if (head == null)
            {
                Console.Write(" " + -1);
            }
            else
            {

                Console.Write(" " + n.ch);
            }
            }


        }


    }



