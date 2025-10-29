class DateModifier
{
    public static int CalculateDaysBetween(string startDate, string endDate)
    {
        DateTime start = DateTime.Parse(startDate);
        DateTime end = DateTime.Parse(endDate);
        return (end - start).Days;
    }
}

public class StartUp
{
    static void Main(string[] args)
    {
        string startDate = Console.ReadLine();
        string endDate = Console.ReadLine();
        int daysBetween = DateModifier.CalculateDaysBetween(startDate, endDate);
        Console.WriteLine(Math.Abs(daysBetween));
    }
}