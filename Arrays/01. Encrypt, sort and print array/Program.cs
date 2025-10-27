// Program may not work correctly in all cases of input (chance of proper output - 60/100)

int n = int.Parse(Console.ReadLine());
int[] codes = new int[n];
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    int sum = 0;
    for (int j = 0; j < input.Length; j++)
        if (GetVowelCode(input[j]) != 0) sum += input[j] * input.Length;
    for (int j = 0; j < input.Length; j++)
        if (GetConsonantCode(input[j]) != 0) sum += input[j] / input.Length;
    codes[i] = sum;
}
Array.Sort(codes);
foreach (int i in codes) Console.WriteLine(i);
static int GetVowelCode(char a)
{
    char[] vowels = {'a', 'e', 'i', 'o', 'u',
                     'A', 'E', 'I', 'O', 'U'};
    for (int i = 0; i < vowels.Length; i++) if (vowels[i] == a) return a;
    return 0;
}
static int GetConsonantCode(char a)
{
    char[] consonants = {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z',
                         'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z'};
    for (int i = 0; i < consonants.Length; i++) if (consonants[i] == a) return a;
    return 0;
}