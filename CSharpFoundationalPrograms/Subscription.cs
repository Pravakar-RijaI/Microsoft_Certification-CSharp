using System;

namespace Test
{
	public class Subscription
	{
		public static void Main()
		{
			Random random = new Random();
			int daysUntilExpiration = random.Next(12);
			//int discountPercentage = 0;
			string welcomeMessage;

			if(daysUntilExpiration <= 10)
			{
				if (daysUntilExpiration < 1)
					welcomeMessage = $"Your subscription has expired.";
				else if (daysUntilExpiration == 1)
					welcomeMessage = $"Your subscription expires with in a day!\nRenew now and save 20%!";
				else if(daysUntilExpiration <= 5)
					welcomeMessage = $"Your subscription expires in {daysUntilExpiration} days\nRenew now and save 10%";
				else
					welcomeMessage = "Your subscription will expire soon. Renew now!";
			}
		}
	}
}


	