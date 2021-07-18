using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Tests.Recursion
{
    class MathRecursionsTestDataGenerator
    {
        public static IEnumerable<object[]> GetNumbersInput()
        {
            yield return new object[]
            {
                new List<char> { 'a', 'b' }, // Input
                new List<List<char>> {
                    new List<char> { 'a', 'b' },
                    new List<char> { 'a' },
                    new List<char> { 'b' },
                    new List<char> { }
                } // Expected Output
            };

            yield return new object[]
            {
                new List<char> { 'a', 'b', 'c' }, // Input
                new List<List<char>> {
                    new List<char> { 'a', 'b', 'c' },
                    new List<char> { 'a', 'b' },
                    new List<char> { 'a', 'c' },
                    new List<char> { 'a' },
                    new List<char> { 'b', 'c' },
                    new List<char> { 'b' },
                    new List<char> { 'c' },
                    new List<char> { },
                } // Expected Output
            };
        }
    }
}
