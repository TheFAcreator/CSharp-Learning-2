class Article
{
    public Article(string title, string content, string author)
    {
        this.Title = title;
        this.Content = content;
        this.Author = author;
    }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public void Edit(string edit)
    {
        this.Content = edit;
    }
    public void Change(string change)
    {
        this.Author = change;
    }
    public void Rename(string update)
    {
        this.Title = update;
    }
    public override string ToString()
    {
        return $"{this.Title} - {this.Content}: {this.Author}";
    }
}
class Program
{
    static void Main()
    {
        string[] analyzer = Console.ReadLine().Split(", ");
        int n = int.Parse(Console.ReadLine());
        Article obj = new Article(analyzer[0], analyzer[1], analyzer[2]);
        for (int i = 0; i < n; i++)
        {
            string[] analyzer2 = Console.ReadLine().Split(":");
            string update = analyzer2[1].Trim();
            switch (analyzer2[0])
            {
                case "Edit":
                    obj.Edit(update);
                    break;
                case "ChangeAuthor":
                    obj.Change(update);
                    break;
                case "Rename":
                    obj.Rename(update);
                    break;
            }
        }
        Console.WriteLine(obj);
    }
}