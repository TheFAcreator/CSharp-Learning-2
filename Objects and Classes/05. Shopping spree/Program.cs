public class Person
{
    public string Name { get; set; }
    public int Money { get; set; }
    public List<string> BagOfProducts { get; set; }
}
public class Product
{
    public string Name { get; set; }
    public int Cost { get; set; }
}
public class Program
{
    static void Main()
    {
        string[] people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
        string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
        List<Person> persons = new List<Person>();
        List<Product> productsList = new List<Product>();
        foreach (string person in people)
        {
            string[] personInfo = person.Split("=");
            persons.Add(new Person
            {
                Name = personInfo[0],
                Money = int.Parse(personInfo[1]),
                BagOfProducts = new List<string>()
            });
        }
        foreach (string product in products)
        {
            string[] productInfo = product.Split("=");
            productsList.Add(new Product
            {
                Name = productInfo[0],
                Cost = int.Parse(productInfo[1])
            });
        }
        string input = "";
        while ((input = Console.ReadLine()) != "END")
        {
            string[] analyzer = input.Split(" ");
            string personName = analyzer[0];
            string productName = analyzer[1];
            Person person = persons.FirstOrDefault(p => p.Name == personName);
            Product product = productsList.FirstOrDefault(p => p.Name == productName);
            if (person.Money - product.Cost >= 0)
            {
                Console.WriteLine(person.Name + " bought " + product.Name);
                person.Money -= product.Cost;
                person.BagOfProducts.Add(product.Name);
            }
            else
            {
                Console.WriteLine(person.Name + " can't afford " + product.Name);
            }
        }
        foreach (Person person in persons)
        {
            if (person.BagOfProducts.Count != 0) Console.WriteLine(person.Name + " - " + string.Join(", ", person.BagOfProducts));
            else Console.WriteLine(person.Name + " - Nothing bought");
        }
    }
}