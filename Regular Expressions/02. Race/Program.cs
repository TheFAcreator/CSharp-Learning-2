using System.Text.RegularExpressions;
class Car
{
    public Car(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public int Distance { get; set; }
}
class Program
{
    static void Main()
    {
        string regex = @"[^A-Za-z]";
        string regex2 = @"[^\d]";
        Car[] cars = Console.ReadLine().Split(", ").Select(g => new Car(g)).ToArray();
        string input = "";
        while ((input = Console.ReadLine()) != "end of race")
        {
            string name = Regex.Replace(input, regex, "");
            Car car = cars.FirstOrDefault(f => f.Name == name);
            if (car == null) continue;
            int[] ints = Regex.Replace(input, regex2, "").ToCharArray().Select(n => n - '0').ToArray();
            int distance = ints.Sum();
            car.Distance += distance;
        }
        cars = cars.OrderByDescending(j => j.Distance).ToArray();
        Console.WriteLine("1st place: " + cars[0].Name);
        Console.WriteLine("2nd place: " + cars[1].Name);
        Console.WriteLine("3rd place: " + cars[2].Name);
    }
}