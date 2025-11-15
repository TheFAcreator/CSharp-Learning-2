using System.Text;
class Program
{
    static void Main()
    {
        StringBuilder str = new(Console.ReadLine());
        string input = "";
        while ((input = Console.ReadLine()) != "Travel")
        {
            string[] analyzer = input.Split(':');
            switch (analyzer[0])
            {
                case "Add Stop":
                    int index = int.Parse(analyzer[1]);
                    if (index >= 0 && index < str.Length)
                    {
                        str.Insert(index, analyzer[2]);
                    }
                    Console.WriteLine(str);
                    break;
                case "Remove Stop":
                    int startIndex = int.Parse(analyzer[1]);
                    int endIndex = int.Parse(analyzer[2]);
                    if (startIndex >= 0 && startIndex < str.Length && endIndex >= 0 && endIndex < str.Length)
                    {
                        str.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(str);
                    break;
                case "Switch":
                    if (str.ToString().Contains(analyzer[1]))
                    {
                        str.Replace(analyzer[1], analyzer[2]);
                    }
                    Console.WriteLine(str);
                    break;
            }
        }
        Console.WriteLine($"Ready for world tour! Planned stops: {str}");
    }
}