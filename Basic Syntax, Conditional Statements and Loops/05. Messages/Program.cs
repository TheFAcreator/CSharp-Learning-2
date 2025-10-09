int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    Console.Write(CorrespondingSymbol(input.Length, int.Parse(input[0].ToString())));
}
static char CorrespondingSymbol(int length, int mainNum)
{
    if (mainNum == 0) return ' ';
    int offset = (mainNum - 2) * 3;
    int index;
    if (mainNum == 8 || mainNum == 9) index = offset + length;
    else index = offset + length - 1;
    return (char)((char)index + 'a');
}