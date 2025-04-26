using Board;
using Interface;

namespace GamePieces
{
    class Pawn : ChessPiece
    {
        public const int Points = 1;

        public Pawn(string color) : base("Pawn", color)
        {
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
