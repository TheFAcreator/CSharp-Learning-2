string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

Func<string, bool> predicate = w => char.IsUpper(w[0]);

Console.WriteLine(string.Join(Environment.NewLine, words.Where(predicate)));