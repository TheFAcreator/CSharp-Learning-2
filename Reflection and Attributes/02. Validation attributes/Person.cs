using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public class Person
    {
        private string fullName;
        private int age;

        [MyRequired]
        public string FullName
        {
            get => this.fullName;
            set => this.fullName = value;
        }

        [MyRange(0, 100)]
        public int Age
        {
            get => this.age;
            set => this.age = value;
        }

        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }
    }
}