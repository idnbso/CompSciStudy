using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Array.Unsorted
{
    class OccurrencesOperations
    {
        /// <summary>
        /// O(n), S(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = nums[0] == 1 ? 1 : 0;
            int curMax = max;

            for (int i = 1; i < nums.Length; i++)
            {
                curMax = nums[i] == 1 ? curMax + 1 : 0;
                max = curMax > max ? curMax : max;
            }

            return max;
        }

        /// <summary>
        /// O(n), S(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindNumbersWithEvenLength(int[] nums)
        {
            int total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int tens = 1;

                for (int x = 1; x <= 5; x++)
                {
                    tens *= 10;

                    if (tens == nums[i] || nums[i] % tens == nums[i])
                    {
                        total = x % 2 == 0 || (tens == nums[i] && (x + 1) % 2 == 0) ? total + 1 : total;
                        break;
                    }
                }
            }

            return total;
        }
    }
}
