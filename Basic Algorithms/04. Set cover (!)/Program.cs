namespace SetCover
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            int[] universe = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int[][] sets = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int[] set = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                sets[i] = set;
            }

            var res = ChooseSets(sets.ToList(), universe.ToList());

            Console.WriteLine($"Sets to take ({res.Count}):");
            foreach (int[] set in res)
            {
                Console.WriteLine($"{{ {string.Join(", ", set)} }}");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> res = new();

            while (sets.Count > 0)
            {
                int[] bestSet = sets.OrderByDescending(n => n.Count(d => universe.Contains(d))).First();
                foreach (int num in bestSet)
                {
                    if (universe.Contains(num))
                    {
                        universe.Remove(num);
                    }
                }

                res.Add(bestSet);

                if (universe.Count == 0) break;

                sets.Remove(bestSet);
            }

            return res;
        }
    }
}