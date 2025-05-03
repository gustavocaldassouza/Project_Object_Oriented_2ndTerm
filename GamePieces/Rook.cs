using Board;

namespace GamePieces
{
    class Rook : ChessPiece
    {
        public const int Points = 5;

        public Rook(string color) : base("Rook", color)
        {
        }

        public override bool IsValidMove(ChessBoard board, string fromPosition, string toPosition)
        {
            throw new NotImplementedException("Rook movement logic not implemented yet.");
        }
    }
}
