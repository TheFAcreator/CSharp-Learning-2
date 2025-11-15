int[] prices = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int entryIndex = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
int entry = prices[entryIndex];
int leftValue = 0;
int rightValue = 0;
for (int i = 0; i < entryIndex; i++)
{
    if (type == "cheap")
    {
        if (prices[i] < entry) leftValue += prices[i];
    }
    else
    {
        if (prices[i] >= entry) leftValue += prices[i];
    }
}
for (int i = entryIndex + 1; i < prices.Length; i++)
{
    if (type == "cheap")
    {
        if (prices[i] < entry) rightValue += prices[i];
    }
    else
    {
        if (prices[i] >= entry) rightValue += prices[i];
    }
}
if (leftValue > rightValue || leftValue == rightValue) Console.WriteLine("Left - " + leftValue);
else Console.WriteLine("Right - " + rightValue);