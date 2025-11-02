int[] analyzer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = analyzer[0];
int cols = analyzer[1];
int[,] matrix = new int[rows, cols];
for (int i = 0; i < rows; i++)
{
    int[] rowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = rowElements[j];
    }
}
int maxSum = int.MinValue;

int maxRow1 = 0;
int maxCol1 = 0;
int maxCol2 = 0;

int maxRow2 = 0;
int maxCol3 = 0;
int maxCol4 = 0;

int maxRow3 = 0;
int maxCol5 = 0;
int maxCol6 = 0;

for (int i = 0; i < rows - 2; i++)
{
    for (int j = 0; j < cols - 2; j++)
    {
        int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                         matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                         matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            maxRow1 = matrix[i, j];
            maxCol1 = matrix[i, j + 1];
            maxCol2 = matrix[i, j + 2];
            maxRow2 = matrix[i + 1, j];
            maxCol3 = matrix[i + 1, j + 1];
            maxCol4 = matrix[i + 1, j + 2];
            maxRow3 = matrix[i + 2, j];
            maxCol5 = matrix[i + 2, j + 1];
            maxCol6 = matrix[i + 2, j + 2];
        }
    }
}
Console.WriteLine("Sum = " + maxSum);
Console.WriteLine(maxRow1 + " " + maxCol1 + " " + maxCol2);
Console.WriteLine(maxRow2 + " " + maxCol3 + " " + maxCol4);
Console.WriteLine(maxRow3 + " " + maxCol5 + " " + maxCol6);