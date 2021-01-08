using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Library.ADT
{
    class DynamicArray<T> : IEnumerable<T>
    {
        private T[] array;
        private int capacity = 0;
        private readonly int CAPACITY_MULTIPLIER = 2;
        public int Length { get; private set; }

        public DynamicArray(int capacity)
        {
            if (capacity < 0) { throw new ArgumentOutOfRangeException($"Illegal Capacity: {capacity}"); }

            this.capacity = capacity;
            InitializeArray(capacity);
        }
        
        public DynamicArray() : this(16) { }

        public bool IsEmpty() { return Length == 0; }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        
        public T Get(int index) { return array[index]; }
        public void Set(int index, T element) { array[index] = element; }

        public void Clear() 
        {
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = default(T);
            }

            Length = 0;
        }

        public void Add(T element)
        {
            // Validate
            if (Length + 1 >= capacity) 
            {
                capacity = capacity == 0 ? 1 : capacity * CAPACITY_MULTIPLIER;
                InitializeArray(capacity);
            }

            // Add
            array[Length] = element;
            Length++;
        }

        public T RemoveAt(int elementIndex)
        {
            if (elementIndex < 0 || elementIndex >= Length) { throw new ArgumentOutOfRangeException($"Illegal Index: {elementIndex}"); }

            T element = array[elementIndex];

            for (int index = elementIndex; index < array.Length - 1; index++)
            {
                array[index] = array[index + 1];
            }

            Length--;

            if (Length <= (capacity / CAPACITY_MULTIPLIER))
            {
                InitializeArray(capacity / CAPACITY_MULTIPLIER);
            }

            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return array.GetEnumerator() as IEnumerator<T>;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

        private void InitializeArray(int capacity)
        {
            var newArray = new object[capacity] as T[];

            for (int index = 0; index < array.Length; index++)
            {
                newArray[index] = array[index];
            }

            array = newArray;
        }
    }
}
