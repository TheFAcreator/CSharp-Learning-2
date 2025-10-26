int num = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= num; i++)
{
    string num2 = i.ToString();
    for (int j = 0; j < num2.Length; j++)
    {
        sum += Convert.ToInt32(num2[j].ToString());
    }
    switch (sum)
    {
        case 5:
        case 7:
        case 11:
            Console.WriteLine(i + " -> True");
            break;
        default:
            Console.WriteLine(i + " -> False");
            break;
    }
    sum = 0;
}