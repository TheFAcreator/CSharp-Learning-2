int n = int.Parse(Console.ReadLine());
long[][] jagged = new long[n][];
for(int i = 0; i < n; i++)
{
    jagged[i] = new long[i + 1];
}
jagged[0][0] = 1;
if (n > 1)
{
    jagged[1][0] = 1;
    jagged[1][1] = 1;
}
for(int i = 2; i < n; i++)
{
    for (int j = 0; j < jagged[i].Length; j++) {
        if (j == 0 || j == jagged[i].Length - 1)
        {
            jagged[i][j] = 1;
        }
        else
        {
            jagged[i][j] = jagged[i - 1][j - 1] + jagged[i - 1][j];
        }
    }
}
for (int i = 0; i < jagged.Length; i++)
{
    Console.WriteLine(string.Join(" ", jagged[i]));
}
/* Shorter version:
 int n = int.Parse(Console.ReadLine());
int[][] jagged = new int[n][];
for (int i = 0; i < n; i++)
{
    jagged[i] = new int[i + 1];
    jagged[i][0] = 1;
    jagged[i][i] = 1;

    for (int j = 1; j < i; j++)
    {
        jagged[i][j] = jagged[i - 1][j - 1] + jagged[i - 1][j];
    }
}
for (int i = 0; i < jagged.Length; i++)
{
    Console.WriteLine(string.Join(" ", jagged[i]));
}
 */