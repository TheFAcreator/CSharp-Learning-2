int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] array2 = new int[array1.Length / 4];
int[] array3 = new int[array1.Length / 4];
for (int i = 0; i < array2.Length; i++)
    array2[i] = array1[i] + array1[array1.Length / 2 - 1 - i];
int j = 0;
for (int i = array1.Length / 2; i < array1.Length / 2 + array1.Length / 4; i++)
{
    array3[j] = array1[i] + array1[array1.Length - j - 1];
    j++;
}
Array.Reverse(array2);
foreach (int h in array2) Console.Write(h + " ");
foreach (int g in array3) Console.Write(g + " ");