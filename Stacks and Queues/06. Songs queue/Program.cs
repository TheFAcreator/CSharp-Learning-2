Queue<string> songs = new(Console.ReadLine().Split(", "));
while(songs.Count > 0)
{
    string command = Console.ReadLine();
    if (command == "Play")
    {
        songs.Dequeue();
    }
    else if (command == "Show")
    {
        Console.WriteLine(string.Join(", ", songs));
    }
    else
    {
        if (!songs.Contains(command.Split("Add ")[1])) songs.Enqueue(command.Split("Add ")[1]);
        else Console.WriteLine(command.Split("Add ")[1] + " is already contained!");
    }
}
Console.WriteLine("No more songs!");