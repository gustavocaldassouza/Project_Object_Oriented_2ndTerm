using Board;
using Interface;

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
            Position positionFrom = new Position(fromPosition[0], fromPosition[1]);
            Position positionTo = new Position(fromPosition[0], toPosition[1]);
            List<string> validMoves = new List<string>();


        }

        public override ChessPiece MovePiece(ChessBoard board, string fromPosition, string toPosition)
        {
            ChessPiece? piece = null;
            if (IsValidMove(board, fromPosition, toPosition))
            {
                piece = board.Board[Convert.ToInt32(toPosition[1].ToString()), Convert.ToInt32(toPosition[0].ToString())];
                return piece;
            }
            return piece!;
        }
    }
}
