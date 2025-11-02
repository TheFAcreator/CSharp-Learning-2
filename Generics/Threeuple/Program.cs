class Threeuple<T1, T2, T3>
{
    public T1 Item1 { get; set; }
    public T2 Item2 { get; set; }
    public T3 Item3 { get; set; }

    public Threeuple(T1 item1, T2 item2, T3 item3)
    {
        Item1 = item1;
        Item2 = item2;
        Item3 = item3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] analyzer = Console.ReadLine().Split(' ', 4);
        string firstName = analyzer[0];
        string lastName = analyzer[1];
        string address = analyzer[2];
        string city = analyzer[3];

        var tuple1 = new Threeuple<string, string, Tuple<string, string>>(firstName, lastName, new Tuple<string, string>(address, city));
        Console.WriteLine(tuple1.Item1 + " " + tuple1.Item2 + " -> " + tuple1.Item3.Item1 + " -> " + tuple1.Item3.Item2);


        analyzer = Console.ReadLine().Split();
        string name = analyzer[0];
        int beerCount = int.Parse(analyzer[1]);
        bool isDrunk = analyzer[2] == "drunk";

        var tuple2 = new Threeuple<string, int, bool>(name, beerCount, isDrunk);
        Console.WriteLine(tuple2.Item1 + " -> " + tuple2.Item2 + " -> " + tuple2.Item3);


        analyzer = Console.ReadLine().Split();
        string name2 = analyzer[0];
        double accountBalance = double.Parse(analyzer[1]);
        string bankName = analyzer[2];

        var tuple3 = new Threeuple<string, double, string>(name2, accountBalance, bankName);
        Console.WriteLine(tuple3.Item1 + " -> " + tuple3.Item2 + " -> " + tuple3.Item3);
    }
}