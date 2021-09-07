using System;
namespace FlippingCoin
{
	class Program
	{

		public class FLIP_COIN
		{

			public static void Main(String[] args)
			{

				// INITIALIZATION
				int n, h_cnt = 0, t_cnt = 0;
				double heads, tails;
				Program u = new Program();

				// INPUT DATA
				Console.WriteLine("enter no. of times you want to flip the coin: ");
				n = u.();

				// COMPUTATION
				for (int j = 0; j < n; j++)
				{
					Random Rand = new Random();
					double random = Math.random();
					if (random < 0.5)
						t_cnt++;
					else
						h_cnt++;
				}

				heads = h_cnt / (double)n * 100;
				tails = t_cnt / (double)n * 100;
				Console.WriteLine("Percentage of heads: " + heads + "%");
				Console.WriteLine("Percentage of tails: " + tails + "%");
				Console.Read();


			}
		}
	}
}
