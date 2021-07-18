using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Array.Unsorted
{
    /// <summary>
    /// Given an array containing N integers, and a number S denoting a target sum.
    /// 
    /// Find two distinct integers that can pair up to form target sum.
    /// </summary>
    public static class PairsByTargetSum
    {
        /// <summary>
        /// Brute Force
        /// O(N^2), S(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public static IDictionary<int, int> GetPairsByTagetSumBruteForce(IList<int> numbers, int targetSum)
        {
            var pairs = new Dictionary<int, int>();

            for (var firstIndex = 0; firstIndex < numbers.Count; firstIndex++)
            {
                var firstNumber = numbers[firstIndex];

                for (int secondIndex = firstIndex + 1; secondIndex < numbers.Count; secondIndex++)
                {
                    var secondNumber = numbers[secondIndex];

                    if (firstNumber + secondNumber == targetSum)
                    {
                        pairs.Add(firstNumber, secondNumber);
                    }
                }
            }

            return pairs;
        }

        /// <summary>
        /// Using Computional Space
        /// O(N), S(N)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public static IDictionary<int, int> GetPairsByTagetSumWithSpace(IList<int> numbers, int targetSum)
        {
            var pairs = new Dictionary<int, int>();
            var set = new HashSet<int>();

            foreach (var firstNumber in numbers)
            {
                var secondNumber = targetSum - firstNumber;
                if (firstNumber != secondNumber && 
                    set.Contains(secondNumber) &&
                    pairs.ContainsKey(secondNumber) == false &&
                    pairs.ContainsKey(firstNumber) == false)
                {
                    pairs.Add(firstNumber, secondNumber);
                }

                set.Add(firstNumber);
            }

            return pairs;
        }

        /// <summary>
        /// Using Binary Search With No Space
        /// O(2Nlog(N)) = O(Nlog(N)), S(1)
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public static IDictionary<int, int> GetPairsByTagetSumWithBinarySearch(IList<int> numbers, int targetSum)
        {
            var pairs = new Dictionary<int, int>();
            var sortedNumbers = numbers.ToArray();
            System.Array.Sort(sortedNumbers);
            
            for (var index = 0; index < sortedNumbers.Length; index++)
            {
                var firstNumber = sortedNumbers[index];
                var targetNumber = targetSum - firstNumber;
                var low = 0;
                var high = sortedNumbers.Length - 1;

                while (low <= high)
                {
                    var middle = (low + high) / 2;
                    var secondNumber = sortedNumbers[middle];

                    if (secondNumber == targetNumber &&
                        firstNumber != secondNumber &&
                        pairs.ContainsKey(secondNumber) == false &&
                        pairs.ContainsKey(firstNumber) == false)
                    {
                        pairs.Add(firstNumber, secondNumber);
                        break;
                    }
                    else if (secondNumber <= targetNumber)
                    {
                        low = middle + 1;
                    }
                    else if (secondNumber > targetNumber)
                    {
                        high = middle - 1;
                    }
                }
            }

            return pairs;
        }
    }
}
