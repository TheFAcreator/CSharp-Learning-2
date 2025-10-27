using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split();
        int[] ints = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            ints[i] = int.Parse(parts[i]);
        }

        int targetSum = int.Parse(Console.ReadLine());

        bool foundPair;

        for (int i = 0; i < ints.Length; i++)
        {
            foundPair = false;
            for (int j = i + 1; j < ints.Length; j++)
            {
                if (ints[i] + ints[j] == targetSum)
                {
                    foundPair = false;
                    for (int k = 0; k < i; k++)
                    {
                        if ((ints[k] == ints[i] && ints[k + 1] == ints[j]) || (ints[k] == ints[j] && ints[k + 1] == ints[i]))
                        {
                            foundPair = true;
                            break;
                        }
                    }
                    if (!foundPair)
                    {
                        Console.WriteLine($"{ints[i]} {ints[j]}");
                    }
                }
            }
        }
    }
}