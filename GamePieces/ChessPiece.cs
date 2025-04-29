using Board;
using Interface;

namespace GamePieces
{
    public abstract class ChessPiece : IMovable
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public ChessPiece(string name, string color)
        {
            if (name == "Knight" || name == "Bishop" || name == "Rook" || name == "Queen" || name == "King" || name == "Pawn")
            {
                Name = name;
            }
            else
            {
                Console.WriteLine("Invalid name. Use 'Knight', 'Bishop', 'Rook', 'Queen', 'King' or 'Pawn'.");
            }
            if (color == "white" || color == "black")
            {
                Color = color;
            }
            else
            {
                Console.WriteLine("Invalid color. Use 'white' or 'black'.");
            }
        }

        public override string ToString()
        {
            return Color.First().ToString().ToUpper() + Name.First().ToString().ToUpper();
        }

        public abstract bool IsValidMove(
            ChessBoard board,
            string fromPosition,
            string toPosition);
        public abstract ChessPiece MovePiece(
            ChessBoard board,
            string fromPosition,
            string toPosition
        );
    }
}
