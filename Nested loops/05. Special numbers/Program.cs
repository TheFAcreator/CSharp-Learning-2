int num = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 1111; i <= 9999; i++)
{
    int copy = i;
    for (int l = 0; l < 4; l++)
    {
        int k = copy % 10;
        copy /= 10;
        if (k == 0) continue;
        else if (num % k == 0) count++;
    }
    if (count == 4) Console.Write(i + " ");
    count = 0;
}