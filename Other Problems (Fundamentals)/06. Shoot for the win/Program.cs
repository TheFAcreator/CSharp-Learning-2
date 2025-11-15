class MyClass
{
    static void Main(string[] args)
    {
        int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string input;
        int shot = 0;
        while ((input = Console.ReadLine()) != "End")
        {
            int index = int.Parse(input);
            if (index >= 0 && index < ints.Length)
            {
                if (ints[index] != -1)
                {
                    for (int i = 0; i < ints.Length; i++)
                    {
                        if (i != index && ints[i] != -1)
                        {
                            if (ints[index] < ints[i]) ints[i] -= ints[index];
                            else ints[i] += ints[index];
                        }
                    }
                    shot++;
                    ints[index] = -1;
                }
            }
        }
        Console.WriteLine("Shot targets: {0} -> {1}", shot, string.Join(" ", ints));
    }
}