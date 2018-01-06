using DoublyLinkedList.Classes;
using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DoublyLinkList dll = new DoublyLinkList(1);

            dll.AddLast(2);
            dll.AddLast(3);
            dll.AddLast(4);
            dll.AddLast(5);
            dll.Output();

            Console.WriteLine("-----");

            dll.AddFirst(0);

            dll.Output();

            Console.WriteLine("--");

            dll.AddBefore(26, 3);

            dll.Output();

            Console.WriteLine("-----");
            dll.AddAfter(45, 4);

            dll.Output();


            Console.WriteLine("---");
            dll.RemoveNode(0);
            dll.Output();

            Console.WriteLine("--");
            dll.RemoveNode(3);
            dll.Output();

            Console.WriteLine("--");
            dll.RemoveNode(5);
            dll.Output();


        }
    }
}
