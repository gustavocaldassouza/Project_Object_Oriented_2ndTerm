using Board;
using Interface;
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
            // extract fromRowIdx and fromColidx from fromPosition
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));
            // extarct toRowIdx and toColidx from toPosition
            int toColIdx = BoardUtils.FileCharToIdx(toPosition[0]);
            int toRowIdx = BoardUtils.RankIntToIdx(int.Parse(toPosition[1].ToString()));

            List<string> possiblePositions = new List<string>();

            //Capture opponent's piece
            ChessPiece? up = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
            ChessPiece? down = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
            ChessPiece? left = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx)}");
            ChessPiece? right = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx)}");
            ChessPiece? upLeft = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
            ChessPiece? upRight = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
            ChessPiece? downLeft = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
            ChessPiece? downRight = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
            if (up != null && up.Color != this.Color && up.Name != "Error" || up == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
            }
            if (down != null && down.Color != this.Color && down.Name != "Error" || up == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
            }
            if (left != null && left.Color != this.Color && left.Name != "Error" || up == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx)}");
            }
            if (right != null && right.Color != this.Color && right.Name != "Error" || up == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx)}");
            }
            if (upLeft != null && upLeft.Color != this.Color && upLeft.Name != "Error" || up == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
            }
            if (upRight != null && upRight.Color != this.Color && upRight.Name != "Error" || up == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
            }
            if (downLeft != null && downLeft.Color != this.Color && downLeft.Name != "Error" || up == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
            }
            if (downRight != null && downRight.Color != this.Color && downRight.Name != "Error" || up == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
            }

            // if the toPos is in the list, return true
            if (possiblePositions.Contains(toPosition.ToUpper()))
            {
                return true;
            }
            return false;
        }

        public override ChessPiece MovePiece(ChessBoard board, string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }
    }
}
