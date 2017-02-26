using System;
namespace Challenges
{
	public class ReverseArray
	{
		public static void ReverseArrayMethod(Array array)
		{
			Console.Write("Reversed Array: ");
			Array.Reverse(array);
			foreach (var item in array)
				Console.Write(item + " ");
		}
	}
}
