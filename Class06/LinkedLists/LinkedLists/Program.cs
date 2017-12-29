using LinkedLists.Classes;
using System;
using System.Collections.Generic;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
            LinkList ll = new LinkList(1);

            ll.AddLast(2);
            ll.AddFirst(3);
            ll.AddBefore(5, 2);
           
         
        }
    }
}
