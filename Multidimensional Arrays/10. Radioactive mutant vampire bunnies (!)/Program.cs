string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);
char[,] matrix = new char[n, m];
int row = 0;
int col = 0;

for (int i = 0; i < n; i++)
{
    string rowElements = Console.ReadLine();
    for (int j = 0; j < m; j++)
    {
        if (rowElements[j] == 'P')
        {
            row = i;
            col = j;
        }
        matrix[i, j] = rowElements[j];
    }
}

string commands = Console.ReadLine();

foreach(char command in commands)
{
    bool exit = false;
    matrix[row, col] = '.';
    int oldRow = row;
    int oldCol = col;
    switch (command)
    {
        case 'U': row--; break;
        case 'D': row++; break;
        case 'L': col--; break;
        case 'R': col++; break;
    }

    bool playerDead = true;
    if (row < 0 || row >= n || col < 0 || col >= m)
    {
        exit = true;
        row = oldRow;
        col = oldCol;
        playerDead = false;
    }
    else if (matrix[row, col] == 'B') exit = true;
    else matrix[row, col] = 'P';

    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            if (matrix[i, j] == 'B')
            {
                if(i > 0 && matrix[i - 1, j] != 'B' && matrix[i - 1, j] != 'H')
                {
                    if (matrix[i - 1, j] == 'P')
                    {
                        matrix[i - 1, j] = 'B';
                        exit = true;
                    }
                    matrix[i - 1, j] = 'H';
                }
                if(i < n - 1 && matrix[i + 1, j] != 'B' && matrix[i + 1, j] != 'H')
                {
                    if (matrix[i + 1, j] == 'P')
                    {
                        matrix[i + 1, j] = 'B';
                        exit = true;
                    }
                    matrix[i + 1, j] = 'H';
                }
                if (j > 0 && matrix[i, j - 1] != 'B' && matrix[i, j - 1] != 'H')
                {
                    if (matrix[i, j - 1] == 'P')
                    {
                        matrix[i, j - 1] = 'B';
                        exit = true;
                    }
                    matrix[i, j - 1] = 'H';
                }
                if (j < m - 1 && matrix[i, j + 1] != 'B' && matrix[i, j + 1] != 'H')
                {
                    if (matrix[i, j + 1] == 'P')
                    {
                        matrix[i, j + 1] = 'B';
                        exit = true;
                    }
                    matrix[i, j + 1] = 'H';
                }
            }
        }
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (matrix[i, j] == 'H')
            {
                matrix[i, j] = 'B';
            }
            if (matrix[i, j] == 'P')
            {
                playerDead = false;
            }
        }
    }
    if (playerDead)
    {
        PrintMatrix(matrix);
        Console.WriteLine("dead: " + row + " " + col);
        break;
    }
    if (exit)
    {
        PrintMatrix(matrix);
        Console.WriteLine("won: " + row + " " + col);
        break;
    }
}

static void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}