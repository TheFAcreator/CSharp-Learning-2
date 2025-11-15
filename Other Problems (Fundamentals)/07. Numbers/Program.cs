class MyClass
{
    static void Main(string[] args)
    {
        int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int avr = ints.Sum() / ints.Length;
        List<int> greater = new();
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] > avr)
                greater.Add(ints[i]);
        }
        if (greater.Count == 0) Console.WriteLine("No");
        else
        {
            greater.Sort();
            greater.Reverse();
            Console.WriteLine(string.Join(" ", greater.Take(5)));
        }
    }
}