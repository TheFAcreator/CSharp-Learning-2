class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }

    public int Weight { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        return $"{Model}:" +
               $"\n  {Engine.Model}:" +
               $"\n    Power: {Engine.Power}" +
               $"\n    Displacement: {(Engine.Displacement == 0 ? "n/a" : Engine.Displacement.ToString())}" +
               $"\n    Efficiency: {Engine.Efficiency ?? "n/a"}" +
               $"\n  Weight: {(Weight == 0 ? "n/a" : Weight)}" +
               $"\n  Color: {Color ?? "n/a"}";
    }
}
class Engine
{
    public string Model { get; set; }
    public int Power { get; set; }

    public int Displacement { get; set; }
    public string Efficiency { get; set; }
}

class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Engine> engines = new();
        
        for(int i = 0; i < n; i++)
        {
            string[] analyzer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = analyzer[0];
            int power = int.Parse(analyzer[1]);

            if(analyzer.Length == 2)
            {
                engines.Add(new Engine { Model = model, Power = power });
            }
            else if(analyzer.Length == 3)
            {
                if(int.TryParse(analyzer[2], out int displacement))
                {
                    engines.Add(new Engine { Model = model, Power = power, Displacement = displacement });
                }
                else
                {
                    engines.Add(new Engine { Model = model, Power = power, Efficiency = analyzer[2] });
                }
            }
            else // analyzer.Length == 4
            {
                engines.Add(new Engine { Model = model, Power = power, Displacement = int.Parse(analyzer[2]), Efficiency = analyzer[3] });
            }
        }

        List<Car> cars = new();

        int m = int.Parse(Console.ReadLine());
        for(int i = 0; i < m; i++)
        {
            string[] analyzer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = analyzer[0];
            Engine engine = engines.First(e => e.Model == analyzer[1]);

            if(analyzer.Length == 2)
            {
                cars.Add(new Car { Model = model, Engine = engine });
            }
            else if(analyzer.Length == 3)
            {
                if(int.TryParse(analyzer[2], out int weight))
                {
                    cars.Add(new Car { Model = model, Engine = engine, Weight = weight });
                }
                else
                {
                    cars.Add(new Car { Model = model, Engine = engine, Color = analyzer[2] });
                }
            }
            else // analyzer.Length == 4
            {
                cars.Add(new Car { Model = model, Engine = engine, Weight = int.Parse(analyzer[2]), Color = analyzer[3] });
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}