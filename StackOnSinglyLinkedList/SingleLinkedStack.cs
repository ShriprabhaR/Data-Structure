using System;
using System.Collections.Generic;
using System.Text;

namespace StackOnSinglyLinkedList
{
    internal class SingleLinkedStack
    {
        internal Node top;

       public SingleLinkedStack()
        {
            this.top = null;
        }

        public void display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node temp = top;
                Console.WriteLine("-------");
                Console.WriteLine("Stack contains...");
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed to stack", data);
        }

        public int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return 0;
            }
            else
            {
                int poppedData = top.data;
                top = top.next;
                Console.WriteLine("{0} popped from stack", poppedData);
                return poppedData;
            }
        }

        public void peek()
        {
            if (top == null)
            {
                Console.WriteLine("No data here");
                return;
            }
            Console.WriteLine("-------");
            Console.WriteLine("{0} is on the top of Stack", top.data);

        }
    }
}
