string[] names = Console.ReadLine().Split();
Array.Reverse(names);
Console.WriteLine(string.Join(' ', names));