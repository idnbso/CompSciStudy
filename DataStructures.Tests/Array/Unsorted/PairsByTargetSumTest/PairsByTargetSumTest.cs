using DataStructures.Array.Unsorted;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.Tests.Array.Unsorted.PairsByTargetSumTest
{
    public class PairsByTargetSumTest
    {
        [Theory]
        [MemberData(nameof(PairsByTargetSumDataGenerator.GetNumbersInput), MemberType = typeof(PairsByTargetSumDataGenerator))]
        public void GetPairByTagetSumBruteForce_NormalInput(int[] inputArray, int targetSum, Dictionary<int, int> expectedOutputArray)
        {
            Assert.Equal(expectedOutputArray, PairsByTargetSum.GetPairsByTagetSumBruteForce(inputArray, targetSum));
        }

        [Theory]
        [MemberData(nameof(PairsByTargetSumDataGenerator.GetNumbersInputWithSortedOutput), MemberType = typeof(PairsByTargetSumDataGenerator))]
        public void GetPairByTagetSumWithSpace_NormalInput(int[] inputArray, int targetSum, Dictionary<int, int> expectedOutputArray)
        {
            Assert.Equal(expectedOutputArray, PairsByTargetSum.GetPairsByTagetSumWithSpace(inputArray, targetSum));
        }

        [Theory]
        [MemberData(nameof(PairsByTargetSumDataGenerator.GetNumbersInputWithSortedOutput), MemberType = typeof(PairsByTargetSumDataGenerator))]
        public void GetPairByTagetSumWithBinarySearch_NormalInput(int[] inputArray, int targetSum, Dictionary<int, int> expectedOutputArray)
        {
            Assert.Equal(expectedOutputArray, PairsByTargetSum.GetPairsByTagetSumWithBinarySearch(inputArray, targetSum));
        }
    }
}
