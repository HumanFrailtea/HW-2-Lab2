using System;

namespace ConsoleApplication1
{
	public class Program
	{
		static void Main(String[] args)
		{

			int COUPONS_PER_CANDYBAR = 10;
			int COUPONS_PER_GUMBALL = 3;
			int numbeOfCouponsWin = 37;

			string userInput;
			userInput = Console.ReadLine();


			int numberOfCandybars = numbeOfCouponsWin / COUPONS_PER_CANDYBAR;

			int remainingCoupons = numbeOfCouponsWin % COUPONS_PER_CANDYBAR;

			int numberOfGumballs = remainingCoupons / COUPONS_PER_GUMBALL;

			remainingCoupons = remainingCoupons % COUPONS_PER_GUMBALL;

			Console.WriteLine("Number of coupons win:       " + numbeOfCouponsWin);
			Console.WriteLine("Number of candy bars get:    " + numberOfCandybars);
			Console.WriteLine("Number of gumballs get:      " + numberOfGumballs);
			Console.WriteLine("Number of remaining coupons: " + remainingCoupons);

			Console.ReadLine();
		}
	}

}