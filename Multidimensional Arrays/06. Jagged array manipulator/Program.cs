int rows = int.Parse(Console.ReadLine());
double[][] jagged = new double[rows][];
for(int i = 0; i < rows; i++)
{
    jagged[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
}
for(int i = 0; i < rows - 1; i++)
{
    if(jagged[i].Length == jagged[i + 1].Length)
    {
        for (int j = 0; j < jagged[i].Length; j++)
        {
            jagged[i][j] *= 2;
            jagged[i + 1][j] *= 2;
        }
    }
    else
    {
        for (int j = 0; j < jagged[i].Length; j++)
        {
            jagged[i][j] /= 2;
        }
        for (int j = 0; j < jagged[i + 1].Length; j++)
        {
            jagged[i + 1][j] /= 2;
        }
    }
}
string input = "";
while((input = Console.ReadLine()) != "End")
{
    string[] analyzer = input.Split();
    try
    {
        if (analyzer[0] == "Add")
        {
            jagged[int.Parse(analyzer[1])][int.Parse(analyzer[2])] += double.Parse(analyzer[3]);
        }
        else
        {
            jagged[int.Parse(analyzer[1])][int.Parse(analyzer[2])] -= double.Parse(analyzer[3]);
        }
    }
    catch { }
}
for (int i = 0; i < jagged.Length; i++)
{
    Console.WriteLine(string.Join(" ", jagged[i]));
}