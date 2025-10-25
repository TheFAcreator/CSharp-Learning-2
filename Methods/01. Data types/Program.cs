string type = Console.ReadLine();
string variable = Console.ReadLine();
if (type != "real") Console.WriteLine(Result(variable, type));
else Console.WriteLine($"{double.Parse(Result(variable, type)):f2}");
static string Result(string variable, string type)
{
    switch (type)
    {
        case "int":
            return (int.Parse(variable) * 2).ToString();
        case "real":
            return (double.Parse(variable) * 1.5).ToString();
        case "string":
            return "$" + variable + "$";
    }
    return "";
}