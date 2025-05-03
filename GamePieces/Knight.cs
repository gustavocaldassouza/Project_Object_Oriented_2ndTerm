using Board;
using Utils;

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
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));

            List<ChessPiece> movePositions = new List<ChessPiece>();
            movePositions.Add(board.PositionToPiece(fromColIdx + 1, fromRowIdx - 2));
            movePositions.Add(board.PositionToPiece(fromColIdx - 1, fromRowIdx - 2));
            movePositions.Add(board.PositionToPiece(fromColIdx + 1, fromRowIdx + 2));
            movePositions.Add(board.PositionToPiece(fromColIdx - 1, fromRowIdx + 2));
            movePositions.Add(board.PositionToPiece(fromColIdx + 2, fromRowIdx - 1));
            movePositions.Add(board.PositionToPiece(fromColIdx - 2, fromRowIdx - 1));
            movePositions.Add(board.PositionToPiece(fromColIdx + 2, fromRowIdx + 1));
            movePositions.Add(board.PositionToPiece(fromColIdx - 2, fromRowIdx + 1));

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
