class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Family
{
    public List<Person> members;
    public void AddMember(Person person)
    {
        members.Add(person);
    }
    public Person GetOldestMember()
    {
        return members.OrderByDescending(j => j.Age).FirstOrDefault();
    }
}
class Program
{
    static void Main()
    {
        Family family = new Family();
        family.members = new();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split();
            family.AddMember(new Person() { Name = analyzer[0], Age = int.Parse(analyzer[1]) });
        }
        Console.WriteLine(family.GetOldestMember().Name + " " + family.GetOldestMember().Age);
    }
}