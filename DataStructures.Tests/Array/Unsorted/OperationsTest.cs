using DataStructures.Array.Unsorted;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DataStructures.Tests.Array.Unsorted
{
    public class OperationsTest
    {
        [Fact]
        public void LinearSearchTest()
        {
            // Arrange
            var testCases = new[] 
            {
                new { Array = new int[]{ }, Element = 40, Expected = -1 },
                new { Array = new int[] { 12, 34, 10, 6, 40 }, Element = 40, Expected = 5 },
                new { Array = new int[] { 12, 34, 10, 6, 40 }, Element = 4, Expected = -1 }
            };

            // Act
            var actualResults = testCases.Select(t => UnsortedOperations.GetElementPosition(t.Array, t.Element)).ToList();

            // Assert
            foreach (var testCaseIndex in Enumerable.Range(0, testCases.Length))
            {
                Assert.Equal(testCases[testCaseIndex].Expected, actualResults[testCaseIndex]);
            }

        }
    }
}
