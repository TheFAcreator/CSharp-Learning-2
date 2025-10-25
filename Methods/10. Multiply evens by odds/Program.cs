static int GetMultipleOfEvenAndOdds(int num)
{
    return GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
}
static int GetSumOfEvenDigits(int n)
{
    int sum = 0;
    for (; n >= 1; n /= 10) if ((n % 10) % 2 == 0) sum += n % 10;
    return sum;
}
static int GetSumOfOddDigits(int n)
{
    int sum = 0;
    for (; n >= 1; n /= 10) if ((n % 10) % 2 != 0) sum += n % 10;
    return sum;
}
int num = Math.Abs(int.Parse(Console.ReadLine()));
Console.WriteLine(GetMultipleOfEvenAndOdds(num));