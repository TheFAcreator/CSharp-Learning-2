using System.Collections;

public class Lake : IEnumerable<int>
{
    List<int> oddStones = new();
    List<int> evenStones = new();

    public Lake(params int[] stones)
    {
        for (int i = 0; i < stones.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenStones.Add(stones[i]);
            }
            else
            {
                oddStones.Add(stones[i]);
            }
        }

        oddStones.Reverse();
    }

    public IEnumerator<int> GetEnumerator()
    {   
        foreach(var stone in evenStones)
        {
            yield return stone;
        }

        foreach(var stone in oddStones)
        {
            yield return stone;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class StartUp
{
    static void Main(string[] args)
    {
        int[] stones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Lake lake = new(stones);

        Console.WriteLine(string.Join(", ", lake));
    }
}