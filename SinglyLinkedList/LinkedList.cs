using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    internal class LinkedList
    {
        internal Node head;


        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");

            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.Write(temp.data);
                    if (temp.next != null)
                    {
                        Console.Write("->");
                    }
                    temp = temp.next;
                }
            }
        }
        public void InsertFirst(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;

            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public void InsertLast(int data)
        {
            Node newNode2 = new Node(data);
            if(head == null)
            {
                head = newNode2;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode2;

            }
        }

        public Node GetLastNode()
        {
            if (head == null)
            {
                Console.WriteLine("Data not found");
                return null;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                return temp;
            }

        }

        public void InsertAfterNode(Node prevNode, int data)
        {
            if(prevNode == null)
            {
                Console.WriteLine("data/node not available");
            }
            else
            {
                Node newNode3 = new Node(data);
                newNode3.next = prevNode.next;
                prevNode.next = newNode3;

            }
        }

        public int DeleteFirst()
        {   
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return 0;
            }
            else
            {
                Node temp = head;
                head = head.next;
                return temp.data;
            }

        }

        public int DeleteLast()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return 0;
            }
            else
            {
                Node temp = head;
                Node lastNode = GetLastNode();
                while (temp.next != lastNode)
                {
                    
                    temp = temp.next;
                }
                temp.next = null;
                return lastNode.data;
            }


        }

        public void DeleteAfter(Node prevNode)
        {

        }
    }
}
