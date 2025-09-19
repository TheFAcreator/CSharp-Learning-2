int chicken = int.Parse(Console.ReadLine());
int fish = int.Parse(Console.ReadLine());
int veggetarian = int.Parse(Console.ReadLine());
double chicken2 = chicken * 10.35;
double fish2 = fish * 12.40;
double veggetarian2 = veggetarian * 8.15;
double sum = (chicken2 + fish2 + veggetarian2) * 0.2 + chicken2 + fish2 + veggetarian2 + 2.5;
Console.WriteLine(sum);