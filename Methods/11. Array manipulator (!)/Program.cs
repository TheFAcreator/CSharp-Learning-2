// Program may not work correctly in all cases of input (chance of proper output - 50/100)

short[] array = Console.ReadLine().Split().Select(short.Parse).ToArray();
for (byte i = 0; i <= 50; i++)
{
    string command = Console.ReadLine();
    if (command == "end") break;
    string[] array2 = command.Split();
    if (array2[0] == "exchange") array = Exchange(int.Parse(array2[1]), array);
    else if (array2[0] == "max") Console.WriteLine(MaxElement(array2[1], array));
    else if (array2[0] == "min") Console.WriteLine(MinElement(array2[1], array));
    else if (array2[0] == "first") Console.WriteLine(First(int.Parse(array2[1]), array2[2], array));
    else if (array2[0] == "last") Console.WriteLine(Last(int.Parse(array2[1]), array2[2], array));
}
string finalResult = "[";
finalResult += string.Join(", ", array);
finalResult += "]";
Console.WriteLine(finalResult);
static short[] Exchange(int ind, short[] array)
{
    if (ind < 0 || ind >= array.Length)
    {
        Console.WriteLine("Invalid index");
        return array;
    }
    if (array.Length == 1) return array;
    //if (array.Length == 2)
    //{
    //    short num = array[0];
    //    array[0] = array[1];
    //    array[1] = num;
    //    return array;
    //}
    short[] array2 = new short[ind + 1];
    for (int i = 0; i < array2.Length; i++) array2[i] = array[i];

    for (int i = 0; i + ind + 1 < array.Length; i++) array[i] = array[i + ind + 1];
    int j = 0;
    for (int i = array.Length - ind - 1; i < array.Length; i++, j++) array[i] = array2[j];
    return array;
}
static string MaxElement(string command, short[] array)
{
    if (command == "even")
    {
        short max = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] % 2 == 0 && array[i] >= max) max = array[i];
        if (max == -1) return "No matches";
        return Array.IndexOf(array, max).ToString();
    }
    else
    {
        short max = -1;
        for (int i = 0; i < array.Length; i++) if (array[i] % 2 == 1 && array[i] >= max) max = array[i];
        if (max == -1) return "No matches";
        return Array.IndexOf(array, max).ToString();
    }
}
static string MinElement(string command, short[] array)
{
    if (command == "even")
    {
        short min = 1001;
        for (int i = 0; i < array.Length; i++) if (array[i] % 2 == 0 && array[i] <= min) min = array[i];
        if (min == 1001) return "No matches";
        return Array.IndexOf(array, min).ToString();
    }
    else
    {
        short min = 1001;
        for (int i = 0; i < array.Length; i++) if (array[i] % 2 == 1 && array[i] <= min) min = array[i];
        if (min == 1001) return "No matches";
        return Array.IndexOf(array, min).ToString();
    }
}
static string First(int command, string command2, short[] array)
{
    if (command2 == "even")
    {
        if (command > array.Length) return "Invalid count";
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }

        }
        string result = "[";

        if (count != 0)
        {
            short[] evens = new short[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evens[j] = array[i];
                    j++;
                    if (j == command) break;
                }
            }
            if (command > evens.Length) result += string.Join(", ", evens);
            else result += string.Join(", ", evens.Take(command));
        }
        result += "]";
        return result;
    }
    else
    {
        if (command > array.Length) return "Invalid count";
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 1)
            {
                count++;
            }

        }
        string result = "[";

        if (count != 0)
        {
            short[] odds = new short[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    odds[j] = array[i];
                    j++;
                    if (j == command) break;
                }
            }
            if (command > odds.Length) result += string.Join(", ", odds);
            else result += string.Join(", ", odds.Take(command));
        }
        result += "]";
        return result;
    }
}
static string Last(int command, string command2, short[] array)
{
    if (command2 == "even")
    {
        if (command > array.Length) return "Invalid count";
        int count = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }

        }
        string result = "[";
        if (count != 0)
        {
            short[] evens = new short[count];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    evens[evens.Length - 1 - j] = array[i];
                    j++;
                    if (j == command) break;
                }
            }
            if (command > evens.Length) result += string.Join(", ", evens);
            else result += string.Join(", ", evens.Skip(evens.Length - command));
        }
        result += "]";
        return result;
    }
    else
    {
        if (command > array.Length) return "Invalid count";
        int count = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] % 2 == 1)
            {
                count++;
            }

        }
        string result = "[";
        if (count != 0)
        {
            short[] odds = new short[count];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 1)
                {
                    odds[odds.Length - 1 - j] = array[i];
                    j++;
                    if (j == command) break;
                }
            }
            if (command > odds.Length) result += string.Join(", ", odds);
            else result += string.Join(", ", odds.Skip(odds.Length - command));
        }
        result += "]";
        return result;
    }
}