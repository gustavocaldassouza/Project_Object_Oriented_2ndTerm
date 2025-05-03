using Board;
using Utils;

namespace GamePieces
{
    class King : ChessPiece
    {
        public const int Points = Int32.MaxValue;

        public King(string color) : base("King", color)
        {
        }

        public override bool IsValidMove(ChessBoard board, string fromPosition, string toPosition)
        {
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));

            List<ChessPiece> movePositions = new List<ChessPiece>();
            movePositions.Append(board.PositionToPiece(fromColIdx, fromRowIdx - 1));
            movePositions.Append(board.PositionToPiece(fromColIdx, fromRowIdx + 1));
            movePositions.Append(board.PositionToPiece(fromColIdx - 1, fromRowIdx));
            movePositions.Append(board.PositionToPiece(fromColIdx + 1, fromRowIdx));
            movePositions.Append(board.PositionToPiece(fromColIdx - 1, fromRowIdx - 1));
            movePositions.Append(board.PositionToPiece(fromColIdx + 1, fromRowIdx - 1));
            movePositions.Append(board.PositionToPiece(fromColIdx - 1, fromRowIdx + 1));
            movePositions.Append(board.PositionToPiece(fromColIdx + 1, fromRowIdx + 1));

            List<string> possiblePositions = new List<string>();
            foreach (ChessPiece piece in movePositions)
            {
                if (piece != null && piece.Color != this.Color && piece.Name != "Error" || piece == null)
                {
                    possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx)}");
                }
            }

            return possiblePositions.Contains(toPosition.ToUpper());
        }
    }
}
