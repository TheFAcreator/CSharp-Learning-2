using System.Text;

public class Program
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder("");
        for (int i = 0; i < n; i++) result.Append((char)(char.Parse(Console.ReadLine()) + key));
        Console.WriteLine(result.ToString());
    }
}