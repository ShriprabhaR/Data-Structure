using System;

namespace StackOnSinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedStack stack = new SingleLinkedStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.display();

            stack.Pop();
            stack.display();

        }
    }
}
