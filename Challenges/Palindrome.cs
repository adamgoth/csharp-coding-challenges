using System;
namespace Challenges
{
	public class Palindrome
	{
		public static bool IsPalindrome(string input)
		{
			string lowered = input.ToLower();
			char[] reversedCharArray = lowered.ToCharArray();
			Array.Reverse(reversedCharArray);
			if (new string(reversedCharArray) == lowered)
			{
				Console.WriteLine("TRUE: {0} is a palindrome", input);
				return true;
			}
			else
			{
				Console.WriteLine("FALSE: {0} is not a palindrome", input);
				return false;
			}
		}
	}
}
