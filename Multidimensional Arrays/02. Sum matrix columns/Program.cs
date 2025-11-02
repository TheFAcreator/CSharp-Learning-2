int[] analyzer = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = analyzer[0];
int cols = analyzer[1];
int[] sum = new int[cols];
for (int i = 0; i < rows; i++)
{
    int[] rowElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int j = 0; j < cols; j++)
    {
        sum[j] += rowElements[j];
    }
}
foreach(int s in sum)
{
    Console.WriteLine(s);
}