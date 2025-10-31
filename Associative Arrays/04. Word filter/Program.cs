string[] filteredWords = Console.ReadLine().Split().Where(n => n.Length % 2 == 0).ToArray();
foreach (string word in filteredWords) Console.WriteLine(word);