Action<string> insertSir = name => Console.WriteLine($"Sir {name}");

Console.ReadLine().Split().ToList().ForEach(name => insertSir(name));