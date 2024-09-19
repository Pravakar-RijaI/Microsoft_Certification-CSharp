using System;

namespace CSharpFoundational
{
	public class OrderId
	{
		public static void Main()
		{
			//Creating a empty list of Order Ids
			string[] orderIds = new string[5];

			//Creating prefix and suffix value to create a random Order Id		
			Random character = new Random();
			string prefix, suffix;

			for(int i = 0; i < orderIds; i++)
			{
				prefix = Convert.ToChar(character.Next(65,71)).toString();
				suffix = character.Next(1,1000).toString("000");
				OrderIds[i] = prefix + suffix;
			}

			foreach(string item in orderIds)
			{
				Console.WriteLine(item);
			}
		}
	}
}

