using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Library.ADT.Queue
{
    class LinkedQueue<T>
    {
        private Node _head;
        private Node _tail;

        private class Node
        {
            public T Item;
            public Node Next;

            public Node(T item, Node next)
            {
                Item = item;
                Next = next;
            }
        }

        public bool IsEmpty() => _head == null;

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            var item = _head.Item;
            _head = _head.Next;

            if (IsEmpty())
            {
                _tail = null;
            }

            return item;
        }

        public void Enqueue(T item)
        {
            var node = new Node(item, null);
            _tail.Next = node;
            _tail = node;

            if (IsEmpty())
            {
                _head = _tail;
            }
        }
    }
}
