class MyClass
{
    static void Main(string[] args)
    {
        List<string> numbers = Console.ReadLine().Split().ToList();
        string input;
        int moves = 0;
        while ((input = Console.ReadLine()) != "end")
        {
            moves++;
            int[] analyzer = input.Split().Select(int.Parse).ToArray();
            if (analyzer[0] < 0 || analyzer[0] >= numbers.Count || analyzer[1] < 0 || analyzer[1] >= numbers.Count ||
                analyzer[0] == analyzer[1])
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                string newElement = "-" + moves + "a";
                numbers.Insert(numbers.Count / 2, newElement);
                numbers.Insert(numbers.Count / 2, newElement);
            }
            else if (numbers[analyzer[0]] == numbers[analyzer[1]])
            {
                Console.WriteLine($"Congrats! You have found matching elements - {numbers[analyzer[0]]}!");
                if (analyzer[0] > analyzer[1])
                {
                    numbers.RemoveAt(analyzer[0]);
                    numbers.RemoveAt(analyzer[1]);
                }
                else
                {
                    numbers.RemoveAt(analyzer[1]);
                    numbers.RemoveAt(analyzer[0]);
                }
                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }

        if (numbers.Count != 0)
        {
            Console.WriteLine($"Sorry you lose :(\n{string.Join(" ", numbers)}");
        }
    }
}