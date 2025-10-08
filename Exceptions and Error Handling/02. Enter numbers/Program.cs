List<int> numbers = new();

int num = 1;
while(numbers.Count < 10)
{
    try
    {
        num = ReadNumber(num, 100);
        numbers.Add(num);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine(string.Join(", ", numbers));


static int ReadNumber(int start, int end)
{
    int num;

    try
    {
        num = int.Parse(Console.ReadLine());
    }
    catch
    {
        throw new Exception("Invalid Number!");
    }

    if (num <= start || num >= end)
    {
        throw new Exception($"Your number is not in range {start} - 100!");
    }
    return num;
}