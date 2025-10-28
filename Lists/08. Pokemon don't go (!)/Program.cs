using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
        int sum = 0;
        while (pokemons.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());
            if (index < 0)
            {
                int num = pokemons[0];
                pokemons[0] = pokemons[pokemons.Count - 1];
                Changer(num, pokemons);
                sum += num;
            }
            else if (index >= pokemons.Count)
            {
                int num = pokemons[pokemons.Count - 1];
                pokemons[pokemons.Count - 1] = pokemons[0];
                Changer(num, pokemons);
                sum += num;
            }
            else
            {
                int num = pokemons[index];
                pokemons.RemoveAt(index);
                Changer(num, pokemons);
                sum += num;
            }
        }
        Console.WriteLine(sum);
    }
    static void Changer(int num, List<int> pokemons)
    {
        for (int i = 0; i < pokemons.Count; i++)
        {
            if (pokemons[i] <= num) pokemons[i] += num;
            else pokemons[i] -= num;
        }
    }
}