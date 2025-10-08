int[] array = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int exceptionCount = 0;
while(exceptionCount < 3)
{
    string[] analyzer = Console.ReadLine().Split();

    try
    {
        if (analyzer[0] == "Replace")
        {
            int index = int.Parse(analyzer[1]);
            int value = int.Parse(analyzer[2]);

            array[index] = value;
        }
        else if (analyzer[0] == "Print")
        {
            int startIndex = int.Parse(analyzer[1]);
            int endIndex = int.Parse(analyzer[2]);

            List<int> toPrint = new();
            for (int i = startIndex; i <= endIndex; i++)
            {
                toPrint.Add(array[i]);
            }

            Console.WriteLine(string.Join(", ", toPrint));
        }
        else if (analyzer[0] == "Show")
        {
            int index2 = int.Parse(analyzer[1]);

            Console.WriteLine(array[index2]);
        }
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("The index does not exist!");
        exceptionCount++;
    }
    catch (FormatException)
    {
        Console.WriteLine("The variable is not in the correct format!");
        exceptionCount++;
    }
}

Console.WriteLine(string.Join(", ", array));