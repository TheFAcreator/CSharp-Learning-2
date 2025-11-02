int n = int.Parse(Console.ReadLine());
int primaryDiagonalSum = 0;
for(int i = 0; i < n; i++)
{
    int[] rowElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
    primaryDiagonalSum += rowElements[i];
}
Console.WriteLine(primaryDiagonalSum);