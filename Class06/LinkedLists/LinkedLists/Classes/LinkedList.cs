using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Classes
{
    class LinkList
    {
        private Node Head { get; set; }
        private Node Current { get; set; }

        public LinkList(object n)
        {
            Node node = new Node() { Value = n };
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Add First adds a node to the beginning of a linked list
        /// </summary>
        /// <param name="data"></param>
        public void AddFirst(object data)
        {
            Current = Head;
            Node node = new Node() { Value = data };
            node.Next = Head;
            Head = node;
            Current = node;
        }

        /// <summary>
        /// Add Before adds a node before a specified node in a link list
        /// </summary>
        /// <param name="data"></param>
        /// <param name="before"></param>
        public void AddBefore(object data, object before)
        {
            Node node = new Node() { Value = data };
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Next.Value.ToString() == before.ToString())
                {
                    node.Next = Current.Next;
                    Current.Next = node;
                    Current = Current.Next;

                }

                Current = Current.Next;
            }
        }

        
        /// <summary>
        /// Add After adds a node after a speicified node in a linked list
        /// </summary>
        /// <param name="data"></param>
        /// <param name="after"></param>
        public void AddAfter(object data, object after)
        {
            Node node = new Node() { Value = data };
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value.ToString() == after.ToString())
                {
                    node.Next = Current.Next;
                    Current.Next = node;

                }

                Current = Current.Next;
            }
        }

        /// <summary>
        /// Add Last adds a node to the end of a linked list
        /// </summary>
        /// <param name="data"></param>
        public void AddLast(object data)
        {
            Node node = new Node() { Value = data };
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = node;
        }
    }
}
