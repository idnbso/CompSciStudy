using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Recursion
{
    public static class MathRecursions
    {
        /// <summary>
        /// T: O(n)
        /// S: O(n)
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int GetFactorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }

            return num * GetFactorial(num - 1);
        }

        public static List<List<char>> GetCombinations(List<char> elements)
        {
            if (elements.Count == 0) { return new List<List<char>>() { new List<char> { } }; }

            var firstElement = elements[0];
            var restOfElements = elements.GetRange(1, elements.Count - 1);

            var combinationsWithoutFirst = GetCombinations(restOfElements);
            var combinationsWithFirst = new List<List<char>>();

            foreach (var combination in combinationsWithoutFirst)
            {
                var combinationWithFirst = new List<char> { firstElement };
                combinationWithFirst.AddRange(combination);
                combinationsWithFirst.Add(combinationWithFirst);
            }

            var combinations = new List<List<char>>();
            combinations.AddRange(combinationsWithFirst);
            combinations.AddRange(combinationsWithoutFirst);
            return combinations;
        }
    }
}
