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
			Challenges.UniqueLetters.UniqueLettersIn("No duplicates");
			Challenges.UniqueLetters.UniqueLettersIn("abcdefghijklmnopqrstuvwxyz");
			Challenges.UniqueLetters.UniqueLettersIn("AaBbCc");
			Challenges.UniqueLetters.UniqueLettersIn("Hello, world");
		}

	}
}