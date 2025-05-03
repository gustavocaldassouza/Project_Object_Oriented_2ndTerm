using Board;

namespace GamePieces
{
    public class Error : ChessPiece
    {
        public Error() : base("Error", "None")
        {
        }

        public override bool IsValidMove(ChessBoard board, string fromPosition, string toPosition)
        {
            return false;
        }
    }
}
