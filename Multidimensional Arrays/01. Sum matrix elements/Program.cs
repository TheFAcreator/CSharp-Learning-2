int[] analyzer = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = analyzer[0];
int cols = analyzer[1];
int[,] matrix = new int[rows, cols];
int sum = 0;
for (int i = 0; i < rows; i++)
{
    int[] rowElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    sum += rowElements.Sum();
}
Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);