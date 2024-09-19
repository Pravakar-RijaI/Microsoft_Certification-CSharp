using System;

namespace CSharpFoundational
{
	internal class Equality
	{
		public static void Main()
		{
			string str1 = "a ";
			string str2 = " A";
			Console.WriteLine(str1.Trim().ToLower() == str2.Trim().ToLower());
		}
	}
}