using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
        int lengthOfList = ints.Count;
        for (int i = 0; i < lengthOfList / 2; i++)
        {
            ints[i] += ints[ints.Count - 1];
            ints.RemoveAt(ints.Count - 1);
        }
        Console.WriteLine(string.Join(" ", ints));
    }
}