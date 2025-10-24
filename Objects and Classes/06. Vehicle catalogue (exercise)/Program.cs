class Vehicle
{
    public string type;
    public string model;
    public string color;
    public int horsePower;
    public override string ToString()
    {
        string result = "Type: ";
        string append = this.type == "car" ? "Car" : "Truck";
        result += append;
        result += $"\nModel: {this.model}\nColor: {this.color}\nHorsepower: {this.horsePower}";
        return result;
    }
}
class Program
{
    static void Main()
    {
        string input = "";
        System.Collections.Generic.List<Vehicle> vehicles = new();
        while ((input = Console.ReadLine()) != "End")
        {
            string[] analyzer = input.Split();
            vehicles.Add(new Vehicle() { type = analyzer[0], model = analyzer[1], color = analyzer[2], horsePower = int.Parse(analyzer[3]) });
        }
        while ((input = Console.ReadLine()) != "Close the Catalogue")
        {
            Vehicle vehicle = vehicles.FirstOrDefault(n => n.model == input);
            Console.WriteLine(vehicle);
        }
        if (vehicles.Count(g => g.type == "car") != 0) Console.WriteLine($"Cars have average horsepower of: {(double)vehicles.Where(k => k.type == "car").Sum(n => n.horsePower) / vehicles.Count(n => n.type == "car"):f2}.");
        else Console.WriteLine("Cars have average horsepower of: 0.00.");
        if (vehicles.Count(h => h.type == "truck") != 0) Console.WriteLine($"Trucks have average horsepower of: {(double)vehicles.Where(j => j.type == "truck").Sum(n => n.horsePower) / vehicles.Count(n => n.type == "truck"):f2}.");
        else Console.WriteLine("Trucks have average horsepower of: 0.00.");
    }
}