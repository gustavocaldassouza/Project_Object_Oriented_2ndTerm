using GamePieces;

class Player
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Score { get; set; }
    public List<ChessPiece> CapturedPieces { get; set; }

    public Player(string name, string color)
    {
        Name = name;
        Color = color;
        Score = 0;
        CapturedPieces = new List<ChessPiece>();
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Player: {Name}, Color: {Color}, Score: {Score}");
        Console.WriteLine("Captured Pieces:");
        foreach (var piece in CapturedPieces)
        {
            Console.WriteLine(piece.GetType().Name);
        }
    }
}
