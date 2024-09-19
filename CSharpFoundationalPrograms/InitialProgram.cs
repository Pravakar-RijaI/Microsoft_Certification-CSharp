using System;

namespace CSharpFoundational
{
	internal class InitialProgram
	{
		public static void Main()
		{
			//Random dice = new Random();
			//int roll = dice.Next(1,7);
			//Console.WriteLine(roll);

			int firstValue = 500;
			int secondValue = 600;
			int largerValue = Math.Max(firstValue,secondValue);

			Console.WriteLine(largerValue);
		}
	}
}