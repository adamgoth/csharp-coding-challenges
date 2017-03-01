using System;
namespace Challenges
{
	public class SumOddNumbers
	{
		public static void SumOddNumbersUpTo(int num)
		{
			int sum = 0;
			for (int i = 1; i <= num; i++)
			{
				if (i % 2 == 1)
				{
					sum += i;
				}
			}
			Console.WriteLine("Sum of odd numbers 1-{0} is {1}", num, sum);
		}
	}
}
