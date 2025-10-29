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
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Peter";
            person.Age = 20;

            Person person2 = new Person
            {
                Name = "George",
                Age = 18
            };

            Person person3 = new Person
            {
                Name = "Jose",
                Age = 43
            };
        }
    }
}