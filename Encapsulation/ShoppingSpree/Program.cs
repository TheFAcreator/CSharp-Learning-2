using ShoppingSpree;

string[] analyzer = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

List<Person> people = new();
foreach (string item in analyzer)
{
    string[] parts = item.Split('=');
    string name = parts[0].Trim();
    int money = int.Parse(parts[1].Trim());

    try
    {
        Person person = new(name, money);
        people.Add(person);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
}

analyzer = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

List<Product> products = new();
foreach (string item in analyzer)
{
    string[] parts = item.Split('=');
    string name = parts[0].Trim();
    int cost = int.Parse(parts[1].Trim());

    try
    {
        Product product = new(name, cost);
        products.Add(product);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
}

string input;
while ((input = Console.ReadLine()) != "END")
{
    analyzer = input.Split();
    Person person = people.First(p => p.Name == analyzer[0]);
    Product product = products.First(p => p.Name == analyzer[1]);

    if(person.Money >= product.Cost)
    {
        person.Products.Add(product);
        person.Money -= product.Cost;
        Console.WriteLine($"{person.Name} bought {product.Name}");
    }
    else
    {
        Console.WriteLine($"{person.Name} can't afford {product.Name}");
    }
}

foreach(Person person in people)
{
    if (person.Products.Count > 0)
    {
        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(p => p.Name))}");
    }
    else
    {
        Console.WriteLine($"{person.Name} - Nothing bought");
    }
}