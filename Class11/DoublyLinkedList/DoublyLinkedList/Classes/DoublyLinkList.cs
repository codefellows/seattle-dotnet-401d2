using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList.Classes
{
    class DoublyLinkList
    {
        public Node Head { get; set; }
        public Node Runner { get; set; }

        public DoublyLinkList(object value)
        {
            Node node = new Node { Value = value, Previous = null, Next = null };
            Head = node;
            Runner = Head;
        }

        public void AddFirst(object value)
        {
            Runner = Head;
            Node node = new Node { Value = value };
            Head.Previous = node;
            node.Next = Head;
            node.Previous = null;
            Head = node;
        }

        //Add Last (obj Value)
        public void AddLast(object value)
        {
            Runner = Head;
            Node node = new Node { Value = value, Next = null, Previous = null };
            while (Runner.Next != null)
            {
                Runner = Runner.Next;
            }
            // We are on the last node
            Runner.Next = node;
            node.Previous = Runner;


        }

        //Add Before(obj newValue, obj BeforeValue)

        public void AddBefore(object newValue, object beforeValue)
        {
            Runner = Head;
            Node node = new Node { Value = newValue, Previous = null, Next = null };

            while (Runner.Next != null)
            {
                if (Runner.Value.ToString() == beforeValue.ToString())
                {
                    node.Next = Runner;
                    node.Previous = Runner.Previous;
                    Runner.Previous.Next = node;
                    Runner.Previous = node;

                }
                Runner = Runner.Next;

            }

        }

        //Add After(obj New Value, obj AfterValue)

        public void AddAfter(object newValue, object afterValue)
        {
            Runner = Head;
            while (Runner.Next != null)
            {
                if (Runner.Value.ToString() == afterValue.ToString())
                {
                    Node node = new Node { Value = newValue, Previous = Runner, Next = Runner.Next };
                    Runner.Next.Previous = node;
                    Runner.Next = node;
                }

                Runner = Runner.Next;

            }
        }

        //Remove(obj Value)

        public void RemoveNode(object value)
        {
            Runner = Head;

            while (Runner.Next != null)
            {
                if(Head.Next == null)
                {
                    Console.WriteLine("Cannot empty linked list");
                    break;
                }
                if (Head.Value.ToString() == value.ToString())
                {
                    Runner.Next.Previous = null;
                    Head = Runner.Next;
                    Runner.Next = null;
                    Runner = Head;
                    return;
                }
                if (Runner.Value.ToString() == value.ToString())
                {
                    Runner.Previous.Next = Runner.Next;
                    Runner.Next.Previous = Runner.Previous;
                    Runner.Previous = null;
                    Runner.Next = null;
                    Runner = Head;
                }
                Runner = Runner.Next;

            }
            if (Runner.Next == null && Runner.Value.ToString() == value.ToString())
            {
                Runner.Previous.Next = Runner.Next;
                Runner.Previous = null;

            }
            Runner = Head;


        }

        public void Output()
        {
            Runner = Head;
            while (Runner.Next != null)
            {
                Console.Write($"{Runner.Value} --> ");
                Runner = Runner.Next;
            }
            Console.Write($"{Runner.Value} --> null ");

        }
    }
}
