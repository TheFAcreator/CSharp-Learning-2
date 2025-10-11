int requiredLength = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine().Split().ToList();

Predicate<string> isValidLength = name => name.Length <= requiredLength;
names = names.FindAll(isValidLength);

Console.WriteLine(string.Join(Environment.NewLine, names));