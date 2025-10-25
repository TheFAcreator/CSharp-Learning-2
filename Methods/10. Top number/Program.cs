int n = int.Parse(Console.ReadLine());
static void TopNumberChecker(int num)
{
    string num2 = num.ToString();
    int sum = 0;
    for (int i = 0; i < num2.Length; i++) sum += num2[i];
    if (sum % 8 == 0)
    {
        for (int i = 0; i < num2.Length; i++) if (num2[i] % 2 == 1)
            {
                Console.WriteLine(num);
                return;
            }
    }
}
for (int i = 1; i <= n; i++) TopNumberChecker(i);