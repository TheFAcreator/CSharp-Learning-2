class Card
{
    public string Face { get; set; }
    public char Suit { get; set; }

    public Card(string face, char suit)
    {
        Face = face;
        Suit = suit;
    }

    public override string ToString()
    {
        string suitSymbol = Suit switch
        {
            'S' => "\u2660", // Spades
            'H' => "\u2665", // Hearts
            'D' => "\u2666", // Diamonds
            'C' => "\u2663", // Clubs
        };

        return $"[{Face}{suitSymbol}]";
    }
}
class Program
{
    static void Main(string[] args)
    {
        string[] analyzer = Console.ReadLine()!.Split(", ");
        List<Card> cards = new();

        foreach (string card in analyzer)
        {
            try
            {
                string[] analyzer2 = card.Split(' ');
                cards.Add(CreateCard(analyzer2[0], analyzer2[1]));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.WriteLine(string.Join(" ", cards));
    }
    static Card CreateCard(string face, string suit)
    {
        face = face.ToUpper();
        suit = suit.ToUpper();

        switch (face)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                break;
            default:
                throw new Exception("Invalid card!");
        }

        switch(suit)
        {
            case "S":
            case "H":
            case "D":
            case "C":
                break;
            default:
                throw new Exception("Invalid card!");
        }
        return new Card(face, char.Parse(suit));
    }
}