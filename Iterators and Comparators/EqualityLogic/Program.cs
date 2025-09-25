public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        return Name == ((Person)obj).Name && Age == ((Person)obj).Age;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Age);
    }

    public int CompareTo(Person other)
    {
        if(!(Name == other.Name))
            return Name.CompareTo(other.Name);

        return Age.CompareTo(other.Age);
    }
}

public class StartUp
{
    static void Main(string[] args)
    {
        SortedSet<Person> people = new();
        HashSet<Person> peopleHashSet = new();

        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string name = tokens[0];
            int age = int.Parse(tokens[1]);

            Person person = new() { Name = name, Age = age };

            people.Add(person);
            peopleHashSet.Add(person);
        }

        Console.WriteLine(people.Count);
        Console.WriteLine(peopleHashSet.Count);
    }
}