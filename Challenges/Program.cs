using System;

namespace Challenges
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");

			//Challenge #1 - Reverse an array
			//string[] array = { "1", "2", "3" };
			//Challenges.ReverseArray.ReverseArrayMethod(array);

			//Challenge #2 - Convert decimal to binary
			//Challenges.IntegerToBinary.IntegerToBinaryMethod(8);

			//Challenge #3 - Sum Odd Numbers in Range
			//Challenges.SumOddNumbers.SumOddNumbersUpTo(15);

			//Challenge #4 - Determine if string contains unique letters
			//Challenges.UniqueLetters.UniqueLettersIn("No duplicates");
			//Challenges.UniqueLetters.UniqueLettersIn("abcdefghijklmnopqrstuvwxyz");
			//Challenges.UniqueLetters.UniqueLettersIn("AaBbCc");
			//Challenges.UniqueLetters.UniqueLettersIn("Hello, world");

			//Challenge #5 - Determine is string is a palindrome
			//Challenges.Palindrome.IsPalindrome("Racecar");
			//Challenges.Palindrome.IsPalindrome("Rats live on no evil star");
			//Challenges.Palindrome.IsPalindrome("Never odd or even");
			//Challenges.Palindrome.IsPalindrome("Hello, world");

			//Challenge #6 - Determine if two strings have the same characters
			Challenges.SameCharacters.SameCharactersInStrings("abca", "abca");
			Challenges.SameCharacters.SameCharactersInStrings("abc", "cba");
			Challenges.SameCharacters.SameCharactersInStrings("a1 b2", "b 1 a 2");
			Challenges.SameCharacters.SameCharactersInStrings("abc", "abca");
			Challenges.SameCharacters.SameCharactersInStrings("abc", "Abc");
			Challenges.SameCharacters.SameCharactersInStrings("abc", "cbAa");
		}

	}
}