using System;
using System.Collections.Generic;
using System.Text;

namespace StackOnSinglyLinkedList
{
    internal class Node
    {
        internal int data;
        internal Node next;

       internal Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
