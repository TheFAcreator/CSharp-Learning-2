class Person
{
    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main()
    {
        string input = "";
        System.Collections.Generic.List<Person> people = new();
        while ((input = Console.ReadLine()) != "End")
        {
            string[] analyzer = input.Split();
            Person person = people.FirstOrDefault(n => n.ID == analyzer[1]);
            if (person == null) people.Add(new Person() { Name = analyzer[0], ID = analyzer[1], Age = int.Parse(analyzer[2]) });
            else
            {
                person.Name = analyzer[0];
                person.Age = int.Parse(analyzer[2]);
            }
        }
        people = people.OrderBy(n => n.Age).ToList();
        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
        }
    }
}