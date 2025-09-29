namespace Farm
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }

    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("meowing...");
        }
    }
    
    public class StartUp
    {
        public static void Main(string[] args)
        {

        }
    }
}