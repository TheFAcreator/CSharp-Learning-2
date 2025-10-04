using WildFarm.Animals;
using WildFarm.Foods;

namespace WildFarm;

public class StartUp
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new();

        string input;
        while((input = Console.ReadLine()) != "End")
        {
            string[] animalInfo = input.Split();
            string animalType = animalInfo[0];
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);
            string livingRegionOrBreedOrWingSize = animalInfo[3];

            Animal animal;
            if (animalType == "Cat")
            {
                string breed = animalInfo[4];
                animal = new Cat(name, weight, livingRegionOrBreedOrWingSize, breed);
            }
            else if (animalType == "Tiger")
            {
                string breed = animalInfo[4];
                animal = new Tiger(name, weight, livingRegionOrBreedOrWingSize, breed);
            }
            else if (animalType == "Dog")
            {
                animal = new Dog(name, weight, livingRegionOrBreedOrWingSize);
            }
            else if (animalType == "Mouse")
            {
                animal = new Mouse(name, weight, livingRegionOrBreedOrWingSize);
            }
            else if (animalType == "Owl")
            {
                double wingSize = double.Parse(livingRegionOrBreedOrWingSize);
                animal = new Owl(name, weight, wingSize);
            }
            else if (animalType == "Hen")
            {
                double wingSize = double.Parse(livingRegionOrBreedOrWingSize);
                animal = new Hen(name, weight, wingSize);
            }
            else
            {
                continue;
            }

            animals.Add(animal);

            string[] foodInfo = Console.ReadLine().Split();
            if (foodInfo.Length != 2)
            {
                continue;
            }

            string foodType = foodInfo[0];
            int foodQuantity = int.Parse(foodInfo[1]);

            Food food;
            if (foodType == "Vegetable")
            {
                food = new Vegetable(foodQuantity);
            }
            else if (foodType == "Meat")
            {
                food = new Meat(foodQuantity);
            }
            else if (foodType == "Fruit")
            {
                food = new Fruit(foodQuantity);
            }
            else if (foodType == "Seeds")
            {
                food = new Seeds(foodQuantity);
            }
            else
            {
                continue;
            }

            Console.WriteLine(animal.ProduceSound());
            animal.Eat(food);
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}