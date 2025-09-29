using System;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Animal(string name, int age, string gender)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Invalid input!");
            Name = name;

            if (age < 0) throw new Exception("Invalid input!");
            Age = age;

            if (string.IsNullOrWhiteSpace(gender)) throw new Exception("Invalid input!");
            Gender = gender;
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{GetType().Name}\n{Name} {Age} {Gender}\n{ProduceSound()}";
        }
    }
}
