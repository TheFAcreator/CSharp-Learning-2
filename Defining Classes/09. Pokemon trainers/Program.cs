class Trainer
{
    public string Name { get; set; }
    public int Badges { get; set; }
    public List<Pokemon> Pokemons { get; set; } = new();

    public Trainer(string name)
    {
        Name = name;
        Badges = 0;
        Pokemons = new();
    }
}
class Pokemon
{
    public string Name { get; set; }
    public string Element { get; set; }
    public int Health { get; set; }
    public override string ToString()
    {
        return $"{Name} {Element} {Health}";
    }
}
class StartUp
{
    static void Main(string[] args)
    {
        List<Trainer> trainers = new();

        string input;
        while((input = Console.ReadLine()) != "Tournament")
        {
            string[] analyzer = input.Split();
            string trainerName = analyzer[0];
            string pokemonName = analyzer[1];
            string element = analyzer[2];
            int health = int.Parse(analyzer[3]);

            Trainer trainer = trainers.FirstOrDefault(t => t.Name == trainerName);
            if(trainer == null)
            {
                trainer = new Trainer(trainerName);
                trainers.Add(trainer);
            }
            Pokemon pokemon = new Pokemon { Name = pokemonName, Element = element, Health = health };
            trainer.Pokemons.Add(pokemon);
        }

        while((input = Console.ReadLine()) != "End")
        {
            foreach(Trainer trainer in trainers)
            {
                if (trainer.Pokemons.Any(j => j.Element == input)) trainer.Badges++;
                else
                {
                    foreach (Pokemon pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                    trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                }
            }
        }

        foreach(Trainer trainer in trainers.OrderByDescending(g => g.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }
}