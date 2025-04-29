using Board;
using Interface;

namespace GamePieces
{
    class Knight : ChessPiece
    {
        public const int Points = 3;

        public Knight(string color) : base("Knight", color)
        {
        }

        public override string ToString()
        {
            return Color.First().ToString().ToUpper() + "N";
        }

        public override bool IsValidMove(ChessBoard board, string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }

        public override ChessPiece MovePiece(ChessBoard board, string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }
    }
}
