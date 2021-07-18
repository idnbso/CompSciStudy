using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Array.Unsorted.PairsByTargetSumTest
{

    class PairsByTargetSumDataGenerator
    {
        public static IEnumerable<object[]> GetNumbersInput()
        {
            yield return new object[]
            {
                new int[] { 10, 5, 2, 3, -6, 9, 11 }, // Input
                4, // Target Sum
                new Dictionary<int, int> { { 10, -6 } } // Output
            };
        }

        public static IEnumerable<object[]> GetNumbersInputWithSortedOutput()
        {
            yield return new object[]
            {
                new int[] { 10, 10, 5, 2, 3, -6, 9, 11 }, // Input
                4, // Target Sum
                new Dictionary<int, int> { { -6, 10 } } // Output
            };
        }
    }
}