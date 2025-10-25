static string stringPower(string txt, int n)
{
    string newTxt = "";
    for (int i = 0; i < n; i++) newTxt += txt;
    return newTxt;
}
string str = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
Console.WriteLine(stringPower(str, n));