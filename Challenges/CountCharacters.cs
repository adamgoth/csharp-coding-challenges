using System;
using System.Collections.Generic;

namespace Challenges
{
	public class CountCharacters
	{
		public static int CountCharacterIn(char character, string word)
		{
			char[] charArray = word.ToCharArray();
			Dictionary<char, int> dictionary = new Dictionary<char, int>();

			foreach (char chara in charArray)
			{
				if (dictionary.ContainsKey(chara))
					dictionary[chara] += 1;
				else
					dictionary.Add(chara, 1);
			}

			Console.WriteLine("{0} contains {1} occurance(s) of '{2}'", word, dictionary[character], character);
			return dictionary[character];
		}
	}
}
