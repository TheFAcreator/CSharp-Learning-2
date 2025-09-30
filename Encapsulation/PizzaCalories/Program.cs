using PizzaCalories;

Pizza pizza; 
try
{
    pizza = new(Console.ReadLine().Split()[1]);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    return;
}

string[] doughInfo = Console.ReadLine().Split();
try
{
    Dough dough = new(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));

    pizza.Dough = dough;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    return;
}

string input;
while((input = Console.ReadLine()) != "END")
{
    string[] toppingInfo = input.Split();
    string toppingType = toppingInfo[1];
    int grams = int.Parse(toppingInfo[2]);

    try
    {
        Topping topping = new(toppingType, grams);
        pizza.AddTopping(topping);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
}

Console.WriteLine($"{pizza.Name} - {pizza.Calories:F2} Calories.");