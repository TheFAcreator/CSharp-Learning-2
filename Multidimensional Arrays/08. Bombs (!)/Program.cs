int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = row[j];
    }
}

string[] analyzer = Console.ReadLine().Split();
List<(int, int)> bombs = new();

foreach (string indicesPair in analyzer)
{
    int[] analyze = indicesPair.Split(',').Select(int.Parse).ToArray();
    bombs.Add((analyze[0], analyze[1]));
}

foreach (var (i, j) in bombs)
{
    if (matrix[i, j] > 0)
    {
        int damage = matrix[i, j];
        if (i > 0 && matrix[i - 1, j] > 0) matrix[i - 1, j] -= damage;
        if (j > 0 && matrix[i, j - 1] > 0) matrix[i, j - 1] -= damage;
        if (i < n - 1 && matrix[i + 1, j] > 0) matrix[i + 1, j] -= damage;
        if (j < n - 1 && matrix[i, j + 1] > 0) matrix[i, j + 1] -= damage;
        if (i > 0 && j > 0 && matrix[i - 1, j - 1] > 0) matrix[i - 1, j - 1] -= damage;
        if (i < n - 1 && j > 0 && matrix[i + 1, j - 1] > 0) matrix[i + 1, j - 1] -= damage;
        if (i > 0 && j < n - 1 && matrix[i - 1, j + 1] > 0) matrix[i - 1, j + 1] -= damage;
        if (i < n - 1 && j < n - 1 && matrix[i + 1, j + 1] > 0) matrix[i + 1, j + 1] -= damage;
        matrix[i, j] = 0;
    }
}
int count = matrix.Cast<int>().Count(x => x > 0);
Console.WriteLine("Alive cells: " + count);

int sum = matrix.Cast<int>().Where(x => x > 0).Sum();
Console.WriteLine("Sum: " + sum);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}