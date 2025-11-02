int n = int.Parse(Console.ReadLine());
string[] commands = Console.ReadLine().Split();
char[,] matrix = new char[n, n];
int minerRow = 0;
int minerCol = 0;

for (int i = 0; i < n; i++)
{
    char[] rowElements = Console.ReadLine().Split().Select(char.Parse).ToArray();
    for (int j = 0; j < n; j++)
    {
        if (rowElements[j] == 's')
        {
            minerRow = i;
            minerCol = j;
        }
        matrix[i, j] = rowElements[j];
    }
}

int coalsCount = matrix.Cast<char>().Count(x => x == 'c');

foreach(string command in commands)
{
    switch (command)
    {
        case "up":
            if (!Move(matrix, minerRow - 1, minerCol, ref coalsCount)) return;
            if(minerRow > 0) minerRow--;
            break;
        case "down":
            if (!Move(matrix, minerRow + 1, minerCol, ref coalsCount)) return;
            if(minerRow < n - 1) minerRow++;
            break;
        case "left":
            if (!Move(matrix, minerRow, minerCol - 1, ref coalsCount)) return;
            if(minerCol > 0) minerCol--;
            break;
        case "right":
            if (!Move(matrix, minerRow, minerCol + 1, ref coalsCount)) return;
            if(minerCol < n - 1) minerCol++;
            break;
    }
}

Console.WriteLine($"{coalsCount} coals left. ({minerRow}, {minerCol})");

static bool Move(char[,] matrix, int row, int col, ref int coalsCount)
{
    if(row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(0))
    {
        if (matrix[row, col] == 'c')
        {
            coalsCount--;
            matrix[row, col] = '*';
            if (coalsCount == 0)
            {
                Console.WriteLine($"You collected all coals! ({row}, {col})");
                return false;
            }
        }
        else if (matrix[row, col] == 'e')
        {
            Console.WriteLine($"Game over! ({row}, {col})");
            return false;
        }
    }
    return true;
}