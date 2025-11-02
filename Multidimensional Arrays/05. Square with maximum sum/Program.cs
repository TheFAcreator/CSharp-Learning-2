int[] analyzer = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = analyzer[0];
int cols = analyzer[1];
int[,] matrix = new int[rows, cols];
int maxSum = int.MinValue;
for (int i = 0; i < rows; i++)
{
    int[] rowElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = rowElements[j];
    }
}
int maxRow1 = 0;
int maxCol1 = 0;
int maxRow2 = 0;
int maxCol2 = 0;
for (int i = 0; i < rows - 1; i++)
{
    for (int j = 0; j < cols - 1; j++)
    {
        int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            maxRow1 = matrix[i, j];
            maxCol1 = matrix[i, j + 1];
            maxRow2 = matrix[i + 1, j];
            maxCol2 = matrix[i + 1, j + 1];
        }
    }
}
Console.WriteLine(maxRow1 + " " + maxCol1);
Console.WriteLine(maxRow2 + " " + maxCol2);
Console.WriteLine(maxSum);