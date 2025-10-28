using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> products = new();
        for (int i = 0; i < n; i++)
        {
            string product = Console.ReadLine();
            products.Add(product);
        }
        products.Sort();
        for (int i = 1; i <= products.Count; i++) Console.WriteLine($"{i}.{products[i - 1]}");
    }
}