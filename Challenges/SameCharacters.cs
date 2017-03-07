using System;

namespace Challenges
{
	public class SameCharacters
	{
		public static bool SameCharactersInStrings(string a, string b)
		{
			char[] arrayA = a.ToCharArray();
			arrayA = Array.FindAll(arrayA, x => !Char.IsWhiteSpace(x));
			Array.Sort(arrayA);
			char[] arrayB = b.ToCharArray();
			arrayB = Array.FindAll(arrayB, y => !Char.IsWhiteSpace(y));
			Array.Sort(arrayB);
			if (new string(arrayA) == new string(arrayB))
			{
				Console.WriteLine("TRUE: {0} and {1} contain the same characters", a, b);
				return true;
			}
			else
			{
				Console.WriteLine("FALSE: {0} and {1} do not contain the same characters", a, b);
				return false;
			}
		}
	}
}
