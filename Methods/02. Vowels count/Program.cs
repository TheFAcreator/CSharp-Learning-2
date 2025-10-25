string word = Console.ReadLine();
static int VowelsCount(string word)
{
    int count = 0;
    char[] vowels = { 'a', 'e', 'i', 'u', 'o', 'A', 'E', 'I', 'U', 'O' };
    for (int i = 0; i < word.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (word[i] == vowels[j])
            {
                count++;
                break;
            }
        }
    }
    return count;
}
Console.WriteLine(VowelsCount(word));