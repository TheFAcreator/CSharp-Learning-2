using System.Text;

public class Program
{
    static void Main()
    {
        Console.WriteLine("<h1>");
        Console.WriteLine("    " + Console.ReadLine());
        Console.WriteLine("</h1>");
        Console.WriteLine("<article>");
        Console.WriteLine("    " + Console.ReadLine());
        Console.WriteLine("</article>");
        string input = "";
        while ((input = Console.ReadLine()) != "end of comments")
        {
            Console.WriteLine("<div>");
            Console.WriteLine("    " + input);
            Console.WriteLine("</div>");
        }
    }
}