using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Array.Rotations
{
    /// <summary>
    /// 
    /// GFG Arrays PS#1
    /// https://www.geeksforgeeks.org/array-rotation/
    /// 
    /// Program for array rotation
    /// Write a function rotate(ar[], d, n) that rotates arr[] of size n by d elements to the left.
    ///
    /// Example:
    /// 1, 2, 3, 4, 5, 6, 7     ->     3, 4, 5, 6, 7, 1, 2
    /// 
    /// </summary>
    public static class ArrayRotation
    {
        /// <summary>
        /// O(d + (n - d) + d) = O(n + d) = O(n)
        /// S(d)
        /// where d = total positions, n = size of array
        /// </summary>
        /// <param name="arraySize"></param>
        /// <param name="totalPositions"></param>
        /// <returns>Rotated Array</returns>
        static public int[] RotateWithTempArray(int[] sourceArray, int totalPositions)
        {
            if (sourceArray.Length == totalPositions || totalPositions == 0) { return sourceArray; }

            var array = sourceArray.Clone() as int[];
            totalPositions = totalPositions > array.Length ? totalPositions % array.Length : totalPositions;
            var toRotate = new int[totalPositions];

            // Populate elements to rotate
            for (int index = 0; index < totalPositions; index++)
            {
                toRotate[index] = array[index];
            }

            // Shift the array to the left
            for (int index = totalPositions; index < array.Length; index++)
            {
                array[index - totalPositions] = array[index];
            }

            // Assign rotated elements to their new position
            for (int index = array.Length - totalPositions; index < array.Length; index++)
            {
                int toRotateIndex = index - (array.Length - totalPositions);
                array[index] = toRotate[toRotateIndex];
            }

            return array;
        }
    }
}
