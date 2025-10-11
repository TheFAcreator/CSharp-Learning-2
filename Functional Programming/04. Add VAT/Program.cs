string AddVAT(double price)
{
    price = price * 1.2; // 20% VAT
    return $"{price:F2}";
}

Func<double, string> addVAT = AddVAT;

Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine().Split(", ").Select(double.Parse).Select(addVAT)));

// Or in just one line: Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine().Split(", ").Select(double.Parse).Select(p => $"{p * 1.2:F2}")));