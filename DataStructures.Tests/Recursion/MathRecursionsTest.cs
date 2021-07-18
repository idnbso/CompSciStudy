using DataStructures.Recursion;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests.Recursion
{
    public class MathRecursionsTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void GetFactorial_NormalInput(int inputNumber, int expectedResult)
        {
            Assert.Equal(expectedResult, MathRecursions.GetFactorial(inputNumber));
        }

        [Theory]
        [MemberData(nameof(MathRecursionsTestDataGenerator.GetNumbersInput), MemberType = typeof(MathRecursionsTestDataGenerator))]
        public void GetCombinations_NormalInput(List<char> input, List<List<char>> expectedOutput)
        {
            Assert.Equal(expectedOutput, MathRecursions.GetCombinations(input));
        }
    }
}
