int tax = int.Parse(Console.ReadLine());
double sneakers = tax - (tax * 0.4);
double idk = sneakers - (sneakers * 0.2);
double ball = idk / 4;
double accessories = ball / 5;
double sum = sneakers + idk + ball + accessories + tax;
Console.WriteLine(sum);