using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        StringBuilder text = new(Console.ReadLine());
        string input = "";
        while ((input = Console.ReadLine()) != "Decode")
        {
            string[] analyzer = input.Split("|");
            switch (analyzer[0])
            {
                case "ChangeAll":
                    text.Replace(analyzer[1], analyzer[2]); break;
                case "Insert":
                    text.Insert(int.Parse(analyzer[1]), analyzer[2]); break;
                case "Move":
                    string toMove = text.ToString().Substring(0, int.Parse(analyzer[1]));
                    text.Append(toMove);
                    text.Remove(0, int.Parse(analyzer[1]));
                    break;
            }
        }
        Console.WriteLine("The decrypted message is: " + text);
    }
}