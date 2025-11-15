int n = int.Parse(Console.ReadLine());

char[,] fortress = new char[n, n];

int spyRow = -1;
int spyCol = -1;

for (int i = 0; i < n; i++)
{
    string row = Console.ReadLine();
    for (int j = 0; j < n; j++)
    {
        fortress[i, j] = row[j];

        if (row[j] == 'S')
        {
            fortress[i, j] = '.';
            spyRow = i;
            spyCol = j;
        }
    }
}

string command;
int stealthPoints = 100;

while (true)
{
    command = Console.ReadLine();

    switch(command)
    {
        case "up":
            if (spyRow - 1 >= 0)
            {
                spyRow--;
            }
            break;
        case "down":
            if (spyRow + 1 < n)
            {
                spyRow++;
            }
            break;
        case "left":
            if (spyCol - 1 >= 0)
            {
                spyCol--;
            }
            break;
        case "right":
            if (spyCol + 1 < n)
            {
                spyCol++;
            }
            break;
    }

    if (fortress[spyRow, spyCol] == 'G')
    {
        stealthPoints -= 40;

        if(stealthPoints <= 0)
        {
            Console.WriteLine("Mission failed. Spy compromised.");
            fortress[spyRow, spyCol] = 'S';
            break;
        }
    }
    else if (fortress[spyRow, spyCol] == 'B')
    {
        if(stealthPoints + 15 > 100)
        {
            stealthPoints = 100;
        }
        else
        {
            stealthPoints += 15;
        }
    }
    else if (fortress[spyRow, spyCol] == 'E')
    {
        Console.WriteLine("Mission accomplished. Spy extracted successfully.");
        break;
    }

    fortress[spyRow, spyCol] = '.';
}

Console.WriteLine($"Stealth level: {stealthPoints} units");

for(int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(fortress[i, j]);
    }
    Console.WriteLine();
}