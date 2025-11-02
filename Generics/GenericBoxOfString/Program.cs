class Box<T>
{
    public T Value { get; set; }
    public Box(T value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return $"{typeof(T)}: {Value}";
    }
}
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            Console.WriteLine(new Box<string>(input));
        }
    }
}