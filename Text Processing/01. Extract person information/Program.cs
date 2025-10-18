using System.Text;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string txt = Console.ReadLine();
            StringBuilder name = new StringBuilder("");
            StringBuilder age = new StringBuilder("");
            int nameStartIndex = txt.IndexOf('@') + 1;
            int nameEndIndex = txt.IndexOf('|');
            name.Append(txt.Substring(nameStartIndex, nameEndIndex - nameStartIndex));

            int ageStartIndex = txt.IndexOf('#') + 1;
            int ageEndIndex = txt.IndexOf('*');
            age.Append(txt.Substring(ageStartIndex, ageEndIndex - ageStartIndex));
            Console.WriteLine($"{name} is {age} years old.");
        }
    }
}