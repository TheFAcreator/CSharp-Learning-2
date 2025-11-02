int n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];
for (int i = 0; i < n; i++)
{
    string rowElements = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = rowElements[j];
    }
}
int count = 0;
while (true)
{
    int row = -1;
    int col = -1;
    int maxAttacks = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] == 'K')
            {
                /*
                K000K
                00K00
                K000K
                */
                int attacks = 0;
                if (i > 0)
                {
                    if (j > 1 && matrix[i - 1, j - 2] == 'K') attacks++;
                    if (j < n - 2 && matrix[i - 1, j + 2] == 'K') attacks++;
                }
                if (i > 1)
                {
                    if (j > 0 && matrix[i - 2, j - 1] == 'K') attacks++;
                    if (j < n - 1 && matrix[i - 2, j + 1] == 'K') attacks++;
                }
                if (i < n - 1)
                {
                    if (j > 1 && matrix[i + 1, j - 2] == 'K') attacks++;
                    if (j < n - 2 && matrix[i + 1, j + 2] == 'K') attacks++;
                }
                if (i < n - 2)
                {
                    if (j > 0 && matrix[i + 2, j - 1] == 'K') attacks++;
                    if (j < n - 1 && matrix[i + 2, j + 1] == 'K') attacks++;
                }
                if (attacks > maxAttacks)
                {
                    maxAttacks = attacks;
                    row = i;
                    col = j;
                }
            }
        }
    }
    if (row == -1) break;
    matrix[row, col] = '0';
    count++;
}
Console.WriteLine(count);