using Board;
using Utils;

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
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));

            List<ChessPiece> movePositions = new List<ChessPiece>();

            if (this.Color == "White")
            {
                movePositions.Add(board.PositionToPiece(fromColIdx, fromRowIdx - 1));
                if (fromRowIdx == 6)
                {
                    movePositions.Add(board.PositionToPiece(fromColIdx, fromRowIdx - 2));
                }
                movePositions.Append(board.PositionToPiece(fromColIdx + 1, fromRowIdx - 1));
                movePositions.Append(board.PositionToPiece(fromColIdx - 1, fromRowIdx - 1));
            }
            else
            {
                movePositions.Add(board.PositionToPiece(fromColIdx, fromRowIdx + 1));
                if (fromRowIdx == 1)
                {
                    movePositions.Add(board.PositionToPiece(fromColIdx, fromRowIdx + 2));
                }
                movePositions.Append(board.PositionToPiece(fromColIdx - 1, fromRowIdx + 1));
                movePositions.Append(board.PositionToPiece(fromColIdx + 1, fromRowIdx + 1));
            }

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
