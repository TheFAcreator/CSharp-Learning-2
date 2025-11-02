class Box<T> : IComparable<Box<T>> where T : IComparable<T>
{
    public T Value { get; set; }

    public Box(T value)
    {
        Value = value;
    }

    public int CompareTo(Box<T> other)
    {
        return Value.CompareTo(other.Value);
    }

    public override string ToString() => Value.ToString();
}

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Box<double>> boxes = new();
        for (int i = 0; i < n; i++)
        {
            double input = double.Parse(Console.ReadLine());

            boxes.Add(new Box<double>(input));
        }

        double elementToCompare = double.Parse(Console.ReadLine());

        boxes.Add(new Box<double>(elementToCompare));
        boxes.Sort();

        int count = 0;
        for (int i = boxes.Count - 1; i >= 0; i--)
        {
            if (boxes[i].Value == elementToCompare)
            {
                break;
            }
            count++;
        }

        Console.WriteLine(count);
    }
}