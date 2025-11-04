int[] sortedNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
Array.Sort(sortedNums);
Array.Reverse(sortedNums);
for (int i = 0; i < Math.Min(3, sortedNums.Length); i++)
{
    Console.Write(sortedNums[i] + " ");
}
// problem is solvable in one line (LINQ) - Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToArray()));