byte[] analyzer = Console.ReadLine().Split().Select(byte.Parse).ToArray();
int rows = analyzer[0];
int cols = analyzer[1];
char[,] matrix = new char[rows, cols];
string snake = Console.ReadLine();
int snakeIndex = 0;
for (int i = 0; i < rows; i++)
{
    for(int j = 0; j < cols; j++)
    {
        matrix[i, j] = snake[snakeIndex];
        snakeIndex++;
        if (snakeIndex == snake.Length)
        {
            snakeIndex = 0;
        }
    }
    if(i + 1 == rows) break;
    for (int j = cols - 1; j >= 0; j--)
    {
        matrix[i + 1, j] = snake[snakeIndex];
        snakeIndex++;
        if (snakeIndex == snake.Length)
        {
            snakeIndex = 0;
        }
    }
    i++;
}
for(int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}