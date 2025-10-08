string[] analyzer = Console.ReadLine()!.Split();

int sum = 0;
for (int i = 0; i < analyzer.Length; i++)
{
    try
    {
        bool isSuccessful = long.TryParse(analyzer[i], out _);

        if (!isSuccessful)
        {
            throw new FormatException($"The element '{analyzer[i]}' is in wrong format!");
        }

        int num;
        try
        {
            num = checked(int.Parse(analyzer[i]));
        }
        catch (OverflowException)
        {
            throw new OverflowException($"The element '{analyzer[i]}' is out of range!");
        }

        sum += int.Parse(analyzer[i]);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine($"Element '{analyzer[i]}' processed - current sum: {sum}");
    }
}

Console.WriteLine($"The total sum of all integers is: {sum}");