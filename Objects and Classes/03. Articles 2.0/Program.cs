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
    public override string ToString()
    {
        return $"{this.Title} - {this.Content}: {this.Author}";
    }
}
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        System.Collections.Generic.List<Article> articles = new();
        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split(", ");
            articles.Add(new Article(analyzer[0], analyzer[1], analyzer[2]));
        }
        for (int i = 0; i < articles.Count; i++) Console.WriteLine(articles[i]);
    } // Program can be way more simple but the task is to create a list.
}