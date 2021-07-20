using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Library.ADT.Stack
{
    public class ArrayStack<T>
    {
        private int HeadIndex = -1;

        private static readonly int SizeMultiplier = 2;
        private T[] Store = new T[1];

        public int Size { get; private set; } = 1;

        public bool IsEmpty() => HeadIndex == -1;

        public void Push(T item)
        {
            if (HeadIndex == Size)
            {
                Resize(SizeMultiplier);
            }

            Store[++HeadIndex] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            var item = Store[HeadIndex];
            Store[HeadIndex--] = default;

            if (Size > 1 && HeadIndex == Size / 4)
            {
                Resize(-SizeMultiplier);
            }

            return item;
        }

        private void Resize(int sizeMultiplier)
        {
            var newSize = sizeMultiplier > 0 ? Size * sizeMultiplier : Size / sizeMultiplier;
            var newArray = new T[newSize];
            for (int index = 0; index < HeadIndex + 1; index++)
            {
                newArray[index] = Store[index];
            }

            Store = newArray;
            Size = newSize;
        }
    }
}
