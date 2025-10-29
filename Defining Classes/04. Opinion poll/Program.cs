namespace DefiningClasses
{
    public class Family
    {
        public List<Person> members;
        public Family()
        {
            members = new List<Person>();
        }
        public void AddMember(Person person)
        {
            members.Add(person);
        }
        public Person GetOldestMember()
        {
            return members.OrderByDescending(p => p.Age).First();
        }
    }
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                //if (value < 0)
                //{
                //    throw new ArgumentException("Age cannot be negative.");
                //}
                age = value;
            }
        }

        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age) : this()
        {
            Age = age;
        }
        public Person(string name, int age) : this(age)
        {
            Name = name;
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] analyzer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = analyzer[0];
                int age = int.Parse(analyzer[1]);
                family.AddMember(new Person(name, age));
            }

            List<Person> overThirty = family.members.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
            foreach (Person person in overThirty)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}