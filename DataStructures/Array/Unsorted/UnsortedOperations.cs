using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Array.Unsorted
{
    public class UnsortedOperations
    {
        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <returns>Position from 1 to N</returns>
        public static int GetElementPosition(int[] array, int element)
        {
            int elementPosition = -1;

            #region Input Validation

            if (array.Length == 0)
            {
                return elementPosition;
            }

            #endregion Input Validation

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == element)
                {
                    elementPosition = index + 1;
                    break;
                }
            }

            return elementPosition;
        }

        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int GetElementPosition(List<int> array, int element)
        {
            int elementPosition = -1;

            #region Input Validation

            if (array.Count == 0)
            {
                return elementPosition;
            }

            #endregion Input Validation

            for (int index = 0; index < array.Count; index++)
            {
                if (array[index] == element)
                {
                    elementPosition = index + 1;
                    break;
                }
            }

            return elementPosition;
        }

        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="capacity"></param>
        /// <param name="element"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static int InsertElementAtLastPosition(int[] array, int capacity, int element)
        {
            #region Input Validation
            
            if (array.Length == 0 || capacity < array.Length)
            {
                throw new Exception("Invalid input array and capacity values.");
            }

            #endregion Input Validation

            if (array.Length >= capacity)
            {
                return array.Length;
            }

            array[array.Length] = element;
            return array.Length + 1;
        }

        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="element"></param>
        /// <returns>New total array length</returns>
        public static int InsertElementAtPosition(List<int> array, int element)
        {
            #region Input Validation

            if (array.Count == 0)
            {
                throw new Exception("Invalid input array value.");
            }

            #endregion Input Validation

            array.Add(element);
            return array.Count;
        }

        /// <summary>
        /// O(N)
        /// </summary>
        /// <returns></returns>
        public static int DeleteElementAtPosition(int[] array, int capacity, int element)
        {
            int position = GetElementPosition(array, element);

            if (position < 1)
            {
                return capacity;
            }

            // Shift left
            for (int index = position - 1; index < array.Length - 1; index++)
            {
                array[index] = array[index + 1];
            }

            return capacity - 1;
        }
    }
}
