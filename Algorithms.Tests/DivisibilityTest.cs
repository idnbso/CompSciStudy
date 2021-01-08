using Algorithms.Mathematical;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Algorithms.Tests
{
    public class DivisibilityTest
    {
        [Fact]
        public void GetClosestDivisibleNumberTest()
        {
            // Arrange
            var testCases = new[] {
                new { Number = 13, Divisor = 4, Expected = 12 },
                new { Number = -15, Divisor = 6, Expected = -18 },
                new { Number = 15, Divisor = 6, Expected = 12 }
            }.ToList();

            // Act
            var actualResults = testCases.Select(t => Divisibility.GetClosestDivisibleNumber(t.Number, t.Divisor)).ToList();

            // Assert
            foreach (var testCaseIndex in Enumerable.Range(0, testCases.Count))
            {
                Assert.Equal(testCases[testCaseIndex].Expected, actualResults[testCaseIndex]);
            }
        }
    }
}
