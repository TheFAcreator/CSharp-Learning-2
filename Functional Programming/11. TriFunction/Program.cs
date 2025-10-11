int num = int.Parse(Console.ReadLine());
string[] strings = Console.ReadLine().Split();

Func<string, int, bool> baseFunc = (s, i) => s.ToCharArray().Select(c => (int)c).Sum() >= i;

Func<Func<string, int, bool>, string> func = f => strings.Where(s => f(s, num)).First();

Console.WriteLine(func(baseFunc));