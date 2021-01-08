using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Mathematical
{
	public class Series
	{
		#region GetNthTermOfSeriesAP
		/// <summary>
		/// O(N)
		/// </summary>
		/// <param name="series"></param>
		/// <param name="term"></param>
		/// <returns></returns>
		public static int GetNthTermOfSeriesAPBruteForce(int[] series, int term)
		{
			if (series == null || series.Length == 0)
			{
				throw new Exception($"The input series is empty.");
			}
			if (term < 1)
			{
				throw new Exception($"The term {term} cannot be smaller than 1.");
			}

			int difference = series[1] - series[0];
			int nthTerm = series[0];

			for (int index = 1; index < term; index++)
			{
				nthTerm += difference;
			}

			return nthTerm;
		}

		/// <summary>
		/// O(1)
		/// </summary>
		/// <param name="series"></param>
		/// <param name="term"></param>
		/// <returns></returns>
		public static int GetNthTermOfSeriesAP(int[] series, int term)
		{
			if (series == null || series.Length == 0)
			{
				throw new Exception($"The input series is empty.");
			}
			if (term < 1) 
			{ 
				throw new Exception($"The term {term} cannot be smaller than 1."); 
			}

			int firstTerm = series[0];
			int difference = series[1] - firstTerm;

			return (difference * (term - 1)) + firstTerm;
		}

		#endregion GetNthTermOfSeriesAP

		#region GetNthTermOfSeriesGP

		/// <summary>
		/// O(N)
		/// </summary>
		/// <param name="series"></param>
		/// <param name="term"></param>
		/// <returns></returns>
		public static int GetNthTermOfSeriesGPBruteForce(int[] series, int term)
		{
			if (series == null || series.Length == 0)
			{
				throw new Exception($"The input series is empty.");
			}
			if (term < 1)
			{
				throw new Exception($"The term {term} cannot be smaller than 1.");
			}

			double quotient = series[1] / series[0];
			double nthTerm = series[0];

			for (int index = 1; index < term; index++)
			{
				if (index == term - 1)
				{
					nthTerm *= quotient;
					break;
				}
			}

			return Convert.ToInt32(Math.Round(nthTerm));
		}

		/// <summary>
		/// O(1)
		/// </summary>
		/// <param name="series"></param>
		/// <param name="term"></param>
		/// <returns></returns>
		public static int GetNthTermOfSeriesGP(int[] series, int term)
		{
			if (series == null || series.Length == 0)
			{
				throw new Exception($"The input series is empty.");
			}
			if (term < 1)
			{
				throw new Exception($"The term {term} cannot be smaller than 1.");
			}

			int firstTerm = series[0];
			double quotient = series[1] / firstTerm;

			return Convert.ToInt32(Math.Round(firstTerm * Math.Pow(quotient, term - 1)));
		}

		#endregion GetNthTermOfSeriesGP
	}
}
