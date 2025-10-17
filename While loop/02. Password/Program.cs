string user = Console.ReadLine();
string pass = Console.ReadLine();
string pass1 = Console.ReadLine();
while (pass1 != pass)
{
    pass1 = Console.ReadLine();
}
Console.WriteLine($"Welcome {user}!");