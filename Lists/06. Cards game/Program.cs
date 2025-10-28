using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();
        while (true)
        {
            if (deck1.Count == 0)
            {
                int sum = deck2.Sum();
                Console.WriteLine("Second player wins! Sum: " + sum);
                break;
            }
            if (deck2.Count == 0)
            {
                int sum = deck1.Sum();
                Console.WriteLine("First player wins! Sum: " + sum);
                break;
            }
            if (deck1[0] < deck2[0])
            {
                deck2.Add(deck2[0]);
                deck2.Add(deck1[0]);
                deck1.Remove(deck1[0]);
                deck2.Remove(deck2[0]);

            }
            else if (deck1[0] > deck2[0])
            {
                deck1.Add(deck1[0]);
                deck1.Add(deck2[0]);
                deck2.Remove(deck2[0]);
                deck1.Remove(deck1[0]);
            }
            else
            {
                deck1.Remove(deck1[0]);
                deck2.Remove(deck2[0]);
            }
        }
    }
}