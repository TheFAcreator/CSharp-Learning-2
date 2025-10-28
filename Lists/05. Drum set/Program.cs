using System.Collections.Generic;
class Program
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
        string input = "";
        List<int> initial = new();
        initial.AddRange(drumSet);
        while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
        {
            int power = int.Parse(input);
            for (int i = 0; i < drumSet.Count; i++)
            {
                drumSet[i] -= power;
                if (drumSet[i] <= 0)
                {
                    if (budget - initial[i] * 3 > 0)
                    {
                        drumSet[i] = initial[i];
                        budget -= drumSet[i] * 3;
                    }
                    else
                    {
                        drumSet.RemoveAt(i);
                        initial.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
        Console.WriteLine(string.Join(" ", drumSet));
        Console.WriteLine($"Gabsy has {budget:f2}lv.");
    }
}