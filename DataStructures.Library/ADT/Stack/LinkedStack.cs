using System;

namespace DataStructures.Library.ADT.Stack
{
    public class LinkedStack<T>
    {
        private Node First = null;

        private class Node
        {
            public T Item { get; set; }
            public Node Next { get; set; }

            public Node(T item, Node next = null)
            {
                Item = item;
                Next = next;
            }
        }

        public bool IsEmpty() => First == null;

        public void Push(T item)
        {
            var node = new Node(item, First);
            First = node;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            var item = First.Item;
            First = First.Next;
            return item;
        }
    }
}
