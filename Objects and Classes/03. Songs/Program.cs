using System.Collections.Generic;
class Song
{
    public Song(string type, string name, string time)
    {
        this.type = type;
        this.name = name;
        this.time = time;
    }
    public string type;
    public string name;
    public string time;
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Song> objs = new();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split("_");
            objs.Add(new Song(input[0], input[1], input[2]));
        }
        string filter = Console.ReadLine();
        if (filter == "all")
        {
            for (int i = 0; i < objs.Count; i++) Console.WriteLine(objs[i].name);
        }
        else
        {
            for (int i = 0; i < objs.Count; i++)
            {
                if (objs[i].type == filter)
                {
                    Console.WriteLine(objs[i].name);
                }
            }
        }
    }
}