using System;
namespace Challenges
{
	public class IntegerToBinary
	{
		public static void IntegerToBinaryMethod(int num)
		{
			string binary = Convert.ToString(num, 2);
			Console.WriteLine(binary);
		}
	}
}
