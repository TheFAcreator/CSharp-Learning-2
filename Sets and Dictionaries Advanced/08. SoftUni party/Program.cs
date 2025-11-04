HashSet<string> vips = new();
HashSet<string> regulars = new();
string input = "";

while((input = Console.ReadLine()) != "PARTY")
{
    if (char.IsDigit(input[0]))
    {
        vips.Add(input);
    }
    else
    {
        regulars.Add(input);
    }
}

while((input = Console.ReadLine()) != "END")
{
    if (char.IsDigit(input[0]))
    {
        vips.Remove(input);
    }
    else
    {
        regulars.Remove(input);
    }
}

Console.WriteLine(vips.Count + regulars.Count);
if(vips.Count > 0) Console.WriteLine(string.Join(Environment.NewLine, vips));
if(regulars.Count > 0) Console.WriteLine(string.Join(Environment.NewLine, regulars));