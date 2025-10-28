class Program
{
    static void Main()
    {
        List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();
        string[] input = Console.ReadLine().Split();
        int number = int.Parse(input[0]);
        int power = int.Parse(input[1]);
        for (int i = 0; i < ints.Count; i++)
        {
            if (ints[i] == number)
            {
                int j = i - 1;
                int k = 0;
                while (j >= 0 && k < power)
                {
                    ints.RemoveAt(j);
                    j--;
                    k++;
                }
                j = ints.IndexOf(number);
                k = 0;
                ints.Remove(number);
                while (j < ints.Count && k < power)
                {
                    ints.RemoveAt(j);
                    k++;
                }
                i--;
            }
        }
        if (ints.Count > 0) Console.WriteLine(ints.Sum());
        else Console.WriteLine(0);
    }
}