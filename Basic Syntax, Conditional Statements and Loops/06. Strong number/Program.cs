string num = Console.ReadLine(); // int is also an option
int sum = 0;
for (int i = 0; i < num.Length; i++)
{
    int addNum = 1;
    string c = num[i].ToString();
    for (int j = Convert.ToInt32(c); j > 0; j--)
    {
        addNum *= j;
    }
    sum += addNum;
}
int num2 = Convert.ToInt32(num);
if (sum == num2) Console.WriteLine("yes");
else Console.WriteLine("no");