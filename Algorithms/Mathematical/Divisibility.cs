using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Mathematical
{
    public class Divisibility
    {
        /// <summary>
        /// O(1)
        /// </summary>
        /// <param name="number"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static int GetClosestDivisibleNumber(int number, int divisor)
        {
            int remainder = number % divisor;
            return number + (remainder * (number < 0 ? 1 : -1));
        }
    }
}
