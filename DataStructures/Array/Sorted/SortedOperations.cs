using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Array.Sorted
{
    public class SortedOperations
    {
        /// <summary>
        /// O(5n/2), S(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SortedSquaresInPlace(int[] nums)
        {
            int signSwitchIndex = nums.Length;
            bool isNegativeExists = false;

            // Square and find specific cases
            for (int i = 0; i < nums.Length; i++)
            {
                isNegativeExists = isNegativeExists || nums[i] < 0;
                signSwitchIndex = signSwitchIndex == nums.Length && isNegativeExists && nums[i] >= 0 ?
                    i : signSwitchIndex;
                nums[i] *= nums[i];
            }

            if (!isNegativeExists)
            {
                return nums; // all positive
            }

            // Sort negative side first
            for (int i = 0; i < signSwitchIndex / 2; i++)
            {
                swap(nums, i, signSwitchIndex - 1 - i);
            }

            if (signSwitchIndex == nums.Length)
            {
                return nums; // all ex-negative
            }

            int len = nums.Length;
            int j = signSwitchIndex;
            // Sort entire array
            for (int i = 0; i < len && j < len; i++)
            {
                if (nums[i] > nums[j])
                {
                    swap(nums, i, j);

                    int r = 0;
                    while (j + r + 1 < len && nums[j + r] > nums[j + r + 1])
                    {
                        swap(nums, j + r, j + r + 1);
                        r++;
                    }
                }

                j = i + 1 == j ? j + 1 : j;
            }

            return nums;
        }

        /// <summary>
        /// O(n), S(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SortedSquares(int[] nums)
        {
            int[] result = new int[nums.Length];
            int pivot = nums.Length - 1;
            bool isNegativeExists = nums[0] < 0;
            bool isPivotFound = false;

            nums[0] = nums[0] * nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int curSq = nums[i] * nums[i];
                isNegativeExists = isNegativeExists || nums[i] < 0;

                if (isNegativeExists && nums[i] >= 0 && !isPivotFound)
                {
                    pivot = i;
                    isPivotFound = true;
                }
                nums[i] = curSq;
            }

            if (!isPivotFound && isNegativeExists)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = nums[pivot--];
                }

                return result;
            }

            pivot = !isNegativeExists ? 0 : pivot;
            int n = pivot - 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (n >= 0 && (pivot >= nums.Length || nums[n] < nums[pivot]))
                {
                    result[i] = nums[n--];
                }
                else if (pivot < nums.Length)
                {
                    result[i] = nums[pivot++];
                }
            }

            return result;
        }

        private void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
