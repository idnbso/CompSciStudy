using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Recursion
{
    public class Recursions
    {
        /// <summary>
        /// O(n)
        /// S(n), where n is the total activation records created in the stack 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The total sum</returns>
        public int SumWithHeadRecursion(int number)
        {
            if (number <= 0)
            {
                return number;
            }

            var sum = SumWithHeadRecursion(number - 1) + number;
            Console.WriteLine(number);
            return sum;
        }


        /// <summary>
        /// O(n)
        /// S(n), where n is the total activation records created in the stack 
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The total sum</returns>
        public int SumWithTailRecursion(int number)
        {
            if (number <= 0)
            {
                return number;
            }

            Console.WriteLine(number);
            return number + SumWithTailRecursion(number - 1);            
        }

        /// <summary>
        /// O(n)
        /// S(1), where 1 is the only activation record created in the stack
        /// </summary>
        /// <param name="number"></param>
        /// <returns>The total sum</returns>
        public int SumWithIteration(int number)
        {
            int totalSum = number;

            while (number > 0)
            {
                number--;
                totalSum += number;
            }

            return totalSum;
        }
    }
}
