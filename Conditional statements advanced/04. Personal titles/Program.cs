double age = double.Parse(Console.ReadLine());
string gender = Console.ReadLine();
if (age >= 16)
{
    if (gender == "m") Console.WriteLine("Mr.");
    else Console.WriteLine("Ms.");
}
else
{
    if (gender == "f") Console.WriteLine("Miss");
    else Console.WriteLine("Master");
}