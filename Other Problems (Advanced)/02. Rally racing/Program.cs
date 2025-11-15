int n = int.Parse(Console.ReadLine());
string racingNumber = Console.ReadLine();

char[,] track = new char[n, n];

for (int i = 0; i < n; i++)
{
    char[] row = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int j = 0; j < n; j++)
    {
        track[i, j] = row[j];
    }
}

int rowPosition = 0;
int colPosition = 0;

int totalDistance = 0;

bool isFinished = false;

string command;
while((command = Console.ReadLine()) != "End")
{
    if (isFinished) continue;

    if(command == "up")
    {
        rowPosition--;
    }
    else if (command == "down")
    {
        rowPosition++;
    }
    else if (command == "left")
    {
        colPosition--;
    }
    else if (command == "right")
    {
        colPosition++;
    }

    if (track[rowPosition, colPosition] == 'T')
    {
        track[rowPosition, colPosition] = '.';

        bool isFound = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (track[i, j] == 'T')
                {
                    track[i, j] = '.';

                    rowPosition = i;
                    colPosition = j;

                    isFound = true;
                    break;
                }
            }
            if (isFound) break;
        }

        totalDistance += 30;
    }
    else if (track[rowPosition, colPosition] == 'F')
    {
        isFinished = true;
        totalDistance += 10;
    }
    else // '.'
    {
        totalDistance += 10;
    }
}

if(isFinished)
{
    Console.WriteLine($"Racing car {racingNumber} finished the stage!");
}
else
{
    Console.WriteLine($"Racing car {racingNumber} DNF.");
}

Console.WriteLine($"Distance covered {totalDistance} km.");

track[rowPosition, colPosition] = 'C'; // Mark the car's final position

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(track[i, j]);
    }
    Console.WriteLine();
}