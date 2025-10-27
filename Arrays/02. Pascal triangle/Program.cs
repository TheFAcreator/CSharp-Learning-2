int n = int.Parse(Console.ReadLine());
int[] array1 = new int[n];
int[] array2 = new int[n];
array1[0] = 1;
Console.WriteLine(1);
for (int i = 1; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (j != 0) array2[j] = array1[j - 1] + array1[j];
        else array2[j] = array1[j];
    }
    array1 = (int[])array2.Clone();
    foreach (int e in array2) if (e != 0) Console.Write(e + " ");
    Console.WriteLine();
}