public class Program
{
    static void Main()
    {
        char a = char.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        string txt = Console.ReadLine();
        int sum = txt.Where(c => c > a && c < b).Sum(c => (int)c);
        /*alternative:
        int sum = 0;
        for (int i = 0; i < txt.Length; i++)
        {
            if (txt[i] > a && txt[i] < b)
            {
                sum += txt[i];
            }
        }
        */
        Console.WriteLine(sum);
    }
}