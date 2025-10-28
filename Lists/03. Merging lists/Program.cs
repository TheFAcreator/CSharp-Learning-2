using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> ints2 = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> ints3 = new(ints.Count + ints2.Count);
        int i = 0;
        int j = 0;
        for (int k = 0; k < ints.Count + ints2.Count; k++)
        {
            if (k % 2 == 0)
            {
                if (i < ints.Count)
                {
                    ints3.Add(ints[i]);
                    i++;
                }
                else
                {
                    ints3.Add(ints2[j]);
                    j++;
                }
            }
            else
            {
                if (j < ints2.Count)
                {
                    ints3.Add(ints2[j]);
                    j++;
                }
                else
                {
                    ints3.Add(ints[i]);
                    i++;
                }
            }
        }
        Console.WriteLine(string.Join(" ", ints3));
    }
}