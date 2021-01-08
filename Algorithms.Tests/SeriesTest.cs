using Algorithms.Mathematical;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Algorithms.Tests
{
    public class SeriesTest
    {
        [Fact]
        public void GetNthTermOfSeriesAPTest()
        {
            // Arrange
            var seriesesToTest = new[] 
            {
                new { Series = new int[] { 2, 3 }, NthTerm = 4, Expected = 5 },
                new { Series = new int[] { 1, 2 }, NthTerm = 10, Expected = 10 }
            }.ToList();

            // Act
            var actualResults = seriesesToTest.Select(s => Series.GetNthTermOfSeriesAP(s.Series, s.NthTerm)).ToList();
            var actualResultsBF = seriesesToTest.Select(s => Series.GetNthTermOfSeriesAPBruteForce(s.Series, s.NthTerm)).ToList();

            // Assert
            foreach (var seriesIndex in Enumerable.Range(0, seriesesToTest.Count))
            {
                Assert.Equal(seriesesToTest[seriesIndex].Expected, actualResults[seriesIndex]);
                Assert.Equal(seriesesToTest[seriesIndex].Expected, actualResultsBF[seriesIndex]);
            }
        }

        [Fact]
        public void GetNthTermOfSeriesGPTest()
        {
            // Arrange
            var seriesesToTest = new[] 
            {
                new { Series = new int[] { 2, 3 }, NthTerm = 1, Expected = 2 },
                new { Series = new int[] { 1, 2 }, NthTerm = 2, Expected = 2 }
            }.ToList();

            // Act
            var actualResults = seriesesToTest.Select(s => Series.GetNthTermOfSeriesGP(s.Series, s.NthTerm)).ToList();
            var actualResultsBF = seriesesToTest.Select(s => Series.GetNthTermOfSeriesGPBruteForce(s.Series, s.NthTerm)).ToList();

            // Assert
            foreach (var seriesIndex in Enumerable.Range(0, seriesesToTest.Count))
            {
                Assert.Equal(seriesesToTest[seriesIndex].Expected, actualResults[seriesIndex]);
                Assert.Equal(seriesesToTest[seriesIndex].Expected, actualResultsBF[seriesIndex]);
            }
        }
    }
}
