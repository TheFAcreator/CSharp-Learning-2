public class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Town { get; set; }

    public int CompareTo(Person other)
    {
        if(!(Name == other.Name))
            return Name.CompareTo(other.Name);

        if(Age != other.Age)
            return Age.CompareTo(other.Age);

        return Town.CompareTo(other.Town);
    }
}

public class StartUp
{
    static void Main(string[] args)
    {
        List<Person> people = new();

        string input;
        while((input = Console.ReadLine()) != "END")
        {
            string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string name = tokens[0];
            int age = int.Parse(tokens[1]);
            string town = tokens[2];

            Person person = new() { Name = name, Age = age, Town = town };
            people.Add(person);
        }

        int n = int.Parse(Console.ReadLine());
        Person personToCompare = people[n - 1];

        int count = 0;
        for (int i = 0; i < people.Count; i++)
        {
            if(i + 1 != n)
            {
                if(personToCompare.CompareTo(people[i]) == 0)
                {
                    count++;
                }
            }
        }

        if(count == 0)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{count + 1} {people.Count - (count + 1)} {people.Count}");
        }
    }
}