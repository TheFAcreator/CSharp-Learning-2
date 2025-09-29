using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string input;
            while ((input = Console.ReadLine()) != "Beast!")
            {
                string[] animalInfo = Console.ReadLine().Split();
                string name = animalInfo[0];
                int age = int.Parse(animalInfo[1]);
                string gender = animalInfo.Length > 2 ? animalInfo[2] : string.Empty;

                try
                {
                    switch (input)
                    {
                        case "Dog":
                            Dog dog = new Dog(name, age, gender);
                            Console.WriteLine(dog);
                            break;
                        case "Cat":
                            Cat cat = new Cat(name, age, gender);
                            Console.WriteLine(cat);
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, gender);
                            Console.WriteLine(frog);
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(name, age);
                            Console.WriteLine(kitten);
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(name, age);
                            Console.WriteLine(tomcat);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}