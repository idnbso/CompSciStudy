using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Library.ADT.Queue
{
    public class ArrayQueue<T>
    {
        private int _headIndex = 0;
        private int _tailIndex = -1;

        private static readonly int sizeMultiplier = 2;
        public int Size { get; private set; } = 1;
        private T[] _store = new T[1];
        
        public bool IsEmpty() => _tailIndex == -1;

        public void Enqueue(T item)
        {
            if (_tailIndex == Size)
            {
                Resize(sizeMultiplier);
            }

            _store[++_tailIndex] = item;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            var item = _store[_headIndex++];
            _tailIndex = _tailIndex == 0 ? 0 : _tailIndex - 1;


            if (_tailIndex == Size / 4)
            {
                Resize(-sizeMultiplier);
            }

            return item;
        }

        private void Resize(int sizeMultiplier)
        {
            var newSize = sizeMultiplier > 0 ? Size * sizeMultiplier : Size / sizeMultiplier;
            var newStore = new T[newSize];

            for (int index = 0; index < Size; index++)
            {
                newStore[index + _headIndex] = _store[index];
            }

            _headIndex = 0;
            _store = newStore;
            Size = newSize;
        }
    }
}
