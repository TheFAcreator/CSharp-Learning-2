namespace DefiningClasses
{
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
            
        }
    }
}