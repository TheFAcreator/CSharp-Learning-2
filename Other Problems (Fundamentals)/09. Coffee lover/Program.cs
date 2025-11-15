class MyClass
{
    static void Main(string[] args)
    {
        List<string> coffees = Console.ReadLine().Split().ToList();
        byte n = byte.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            switch (input[0])
            {
                case "Include":
                    coffees.Add(input[1]);
                    break;
                case "Remove":
                    if (!(int.Parse(input[2]) > coffees.Count))
                    {
                        if (input[1] == "first") coffees.RemoveRange(0, int.Parse(input[2]));
                        else coffees.RemoveRange(coffees.Count - int.Parse(input[2]), int.Parse(input[2]));
                    }
                    break;
                case "Prefer":
                    if (int.Parse(input[1]) < coffees.Count && int.Parse(input[2]) < coffees.Count)
                        (coffees[int.Parse(input[1])], coffees[int.Parse(input[2])]) = (coffees[int.Parse(input[2])], coffees[int.Parse(input[1])]);
                    break;
                case "Reverse":
                    coffees.Reverse();
                    break;
            }
        }
        Console.WriteLine("Coffees:\n{0}", string.Join(" ", coffees));
    }
}