int n = int.Parse(Console.ReadLine());
int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;
for (int i = 0; i < n; i++)
{
    int[] rowElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
    primaryDiagonalSum += rowElements[i];
    secondaryDiagonalSum += rowElements[n - 1 - i];
}
int difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
Console.WriteLine(difference);