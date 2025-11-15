int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

int playerRow = 0;
int playerCol = 0;

for (int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = line[j];

        if (line[j] == 'S')
        {
            playerRow = i;
            playerCol = j;

            matrix[i, j] = '-';
        }
    }
}

int shipCount = 3;
int minesWithstood = 0;

string command;
while (true)
{
    if(shipCount == 0)
    {
        Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
        break;
    }
    if(minesWithstood == 3)
    {
        Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{playerRow}, {playerCol}]!");
        break;
    }

    command = Console.ReadLine();
    switch (command)
    {
        case "up":
            playerRow--;
            break;
        case "down":
            playerRow++;
            break;
        case "left":
            playerCol--;
            break;
        case "right":
            playerCol++;
            break;
    }

    if (matrix[playerRow, playerCol] == 'C')
    {
        shipCount--;
        matrix[playerRow, playerCol] = '-';
    }
    else if (matrix[playerRow, playerCol] == '*')
    {
        minesWithstood++;
        matrix[playerRow, playerCol] = '-';
    }
}

matrix[playerRow, playerCol] = 'S';
for(int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}