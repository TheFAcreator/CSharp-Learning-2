Queue<int> ints = new(Console.ReadLine().Split().Select(int.Parse));
List<int> evenNumbers = new();
foreach (int number in ints)
{
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    }
}
Console.WriteLine(string.Join(", ", evenNumbers));