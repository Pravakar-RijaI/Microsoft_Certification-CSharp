using System;

namespace CSharpFoundation
{
	internal class Inventory
	{
		public static void Main()
		{
			int[] inventory = {200,450,700,175,250};
			int bin = 0, sum = 0;
	
			foreach(int item in inventory)
			{
				sum += item;
				Console.WriteLine($"Bin{bin}: {item} Running Total: {sum}");
				bin++;
			}
		}
	}
}
	