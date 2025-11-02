class Tuple<T1, T2>
{
    public T1 Item1 { get; set; }
    public T2 Item2 { get; set; }

    public Tuple(T1 item1, T2 item2)
    {
        Item1 = item1;
        Item2 = item2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string[] analyzer = Console.ReadLine().Split();
        string firstName = analyzer[0];
        string lastName = analyzer[1];
        string address = analyzer[2];

        var tuple1 = new Tuple<string, Tuple<string, string>>(firstName, new Tuple<string, string>(lastName, address));
        Console.WriteLine(tuple1.Item1 + " " + tuple1.Item2.Item1 + " -> " + tuple1.Item2.Item2);


        analyzer = Console.ReadLine().Split();
        string name = analyzer[0];
        int beerCount = int.Parse(analyzer[1]);

        var tuple2 = new Tuple<string, int>(name, beerCount);
        Console.WriteLine(tuple2.Item1 + " -> " + tuple2.Item2);


        analyzer = Console.ReadLine().Split();
        int firstNumber = int.Parse(analyzer[0]);
        double secondNumber = double.Parse(analyzer[1]);

        var tuple3 = new Tuple<int, double>(firstNumber, secondNumber);
        Console.WriteLine(tuple3.Item1 + " -> " + tuple3.Item2);
    }
}