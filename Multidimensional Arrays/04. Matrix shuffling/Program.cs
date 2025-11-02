int[] analyzer = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = analyzer[0];
int cols = analyzer[1];
string[,] matrix = new string[rows, cols];
for (int i = 0; i < rows; i++)
{
    string[] rowElements = Console.ReadLine().Split();
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = rowElements[j];
    }
}
string input = "";
while((input = Console.ReadLine()) != "END")
{
    try
    {
        string[] command = input.Split();
        int row = int.Parse(command[1]);
        int col = int.Parse(command[2]);
        int row2 = int.Parse(command[3]);
        int col2 = int.Parse(command[4]);
        (matrix[row, col], matrix[row2, col2]) = (matrix[row2, col2], matrix[row, col]);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    catch
    {
        Console.WriteLine("Invalid input!");
    }
}