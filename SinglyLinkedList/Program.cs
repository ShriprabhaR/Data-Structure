using System;

namespace SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.InsertFirst(20);
            list.InsertFirst(30);
            list.InsertFirst(50);
            list.InsertLast(60);

            list.InsertAfterNode(list.head.next.next, 80);
            list.Display();

            Node newNode =list.GetLastNode();
            Console.WriteLine("\nLast Node: "+newNode.data);

            int deletedNode = list.DeleteFirst();
            Console.WriteLine("Deleted data: "+deletedNode);
            list.Display();

            int deletedLastNode = list.DeleteLast();
            Console.WriteLine("\nDeleted data: " + deletedLastNode);
            list.Display();





        }
    }
}
