int rows = int.Parse(Console.ReadLine());
int[][] jagged = new int[rows][];
for (int i = 0; i < rows; i++)
{
    jagged[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
}
string input = "";
while ((input = Console.ReadLine()) != "END")
{
    try
    {
        string[] analyzer = input.Split();
        if (analyzer[0] == "Add")
        {
            jagged[int.Parse(analyzer[1])][int.Parse(analyzer[2])] += int.Parse(analyzer[3]);
        }
        else
        {
            jagged[int.Parse(analyzer[1])][int.Parse(analyzer[2])] -= int.Parse(analyzer[3]);
        }
    }
    catch
    {
        Console.WriteLine("Invalid coordinates");
    }
}
for (int i = 0; i < jagged.Length; i++)
{
    Console.WriteLine(string.Join(" ", jagged[i]));
}