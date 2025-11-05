using System.Text.RegularExpressions;
using System.Collections.Generic;
class Demon
{
    public string Name { get; set; }
    public int Health { get; set; }
    public double Damage { get; set; }
}
class Program
{
    static void Main()
    {
        string regex = @"\-?\d*\.?\d+";
        string regex2 = @"[^0-9-+*/.]";
        List<Demon> demons = new();
        string[] names = Console.ReadLine().Split(",").Select(m => m.Trim()).ToArray();
        for (int i = 0; i < names.Length; i++)
        {
            int health = 0;
            var matches = Regex.Matches(names[i], regex2);
            foreach (Match match in matches) health += char.Parse(match.Value);
            double damage = 0;
            var matches2 = Regex.Matches(names[i], regex);
            foreach (Match match in matches2) damage += double.Parse(match.Value);
            foreach (char ch in names[i])
                if (ch == '*') damage *= 2;
                else if (ch == '/') damage /= 2;
            demons.Add(new Demon() { Name = names[i], Health = health, Damage = damage });
        }
        demons = demons.OrderBy(n => n.Name).ToList();
        foreach (Demon demon in demons)
            Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
    }
}