class Piece
{
    public string Composer { get; set; }
    public string Key { get; set; }
}
class Program
{
    static void Main()
    {
        List<KeyValuePair<string, Piece>> pieces = new List<KeyValuePair<string, Piece>>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split('|');
            string pieceName = input[0];
            string composer = input[1];
            string key = input[2];
            pieces.Add(new KeyValuePair<string, Piece>(pieceName, new Piece() { Composer = composer, Key = key }));
        }
        string input1 = "";
        while ((input1 = Console.ReadLine()) != "Stop")
        {
            string[] analyzer = input1.Split('|');
            switch (analyzer[0])
            {
                case "Add":
                    string pieceName = analyzer[1];
                    string composer = analyzer[2];
                    string key = analyzer[3];
                    if (pieces.Exists(j => j.Key == pieceName))
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                    else
                    {
                        pieces.Add(new KeyValuePair<string, Piece>(pieceName, new Piece() { Composer = composer, Key = key }));
                        Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                    }
                    break;
                case "Remove":
                    string pieceName1 = analyzer[1];
                    if (pieces.Exists(j => j.Key == pieceName1))
                    {
                        pieces.RemoveAll(h => h.Key == pieceName1);
                        Console.WriteLine($"Successfully removed {pieceName1}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName1} does not exist in the collection.");
                    }
                    break;
                case "ChangeKey":
                    string pieceName2 = analyzer[1];
                    string newKey = analyzer[2];
                    if (pieces.Exists(j => j.Key == pieceName2))
                    {
                        pieces.Find(j => j.Key == pieceName2).Value.Key = newKey;
                        Console.WriteLine($"Changed the key of {pieceName2} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName2} does not exist in the collection.");
                    }
                    break;
            }
        }
        foreach (KeyValuePair<string, Piece> piece in pieces)
            Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
    }
}