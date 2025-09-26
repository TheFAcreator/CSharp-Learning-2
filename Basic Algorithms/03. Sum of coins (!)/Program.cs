namespace SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int sum = int.Parse(Console.ReadLine());

            var res = ChooseCoins(coins, sum);

            Console.WriteLine($"Number of coins to take: {res.Values.Sum()}");
            foreach (var coin in res)
            {
                Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
            }
        }

        public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
        {
            coins = coins.OrderByDescending(x => x).ToList(); // or directly on line 11

            Dictionary<int, int> coinsCount = new();

            for (int i = 0; i < coins.Count; i++)
            {
                int coin = coins[i];

                int count = targetSum / coin;

                if (count != 0)
                {
                    coinsCount[coin] = count;

                    targetSum -= coin * count;
                }
            }

            if(targetSum != 0) throw new NotSupportedException();

            return coinsCount;
        }
    }
}