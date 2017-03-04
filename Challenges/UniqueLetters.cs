using System;
using System.Collections.Generic;

namespace Challenges
{
	public class UniqueLetters
	{
		public static bool UniqueLettersIn(string input)
		{
			List<char> list = new List<char>();

			foreach (var letter in input)
			{
				if (list.Contains(letter))
				{
					Console.WriteLine("False: {0} appears more than once in {1}", letter, input);
					return false;
				}
				else
					list.Add(letter);
			}

			Console.WriteLine("True: {0} contains no duplicate letters", input);
			return true;

		}
	}
}
