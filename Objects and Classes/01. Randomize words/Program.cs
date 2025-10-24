string[] words = Console.ReadLine().Split();
Random rnd = new Random();
for (int i = 0; i < words.Length; i++)
{
    int j = rnd.Next(i, words.Length);
    (words[i], words[j]) = (words[j], words[i]);
}
foreach (string word in words)
{
    Console.WriteLine(word);
}