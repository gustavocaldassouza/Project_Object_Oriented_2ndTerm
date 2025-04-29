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
            // Knight moves in an L shape: two squares in one direction and one square perpendicular
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));
            int toColIdx = BoardUtils.FileCharToIdx(toPosition[0]);
            int toRowIdx = BoardUtils.RankIntToIdx(int.Parse(toPosition[1].ToString()));

            List<string> possiblePositions = new List<string>();
            // Generate all possible positions for the knight
            ChessPiece? lLieUpLeft = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 2)}");
            ChessPiece? lLieDownLeft = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 2)}");
            ChessPiece? lLieUpRight = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 2)}");
            ChessPiece? lLieDownRight = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 2)}");
            ChessPiece? lStandUpLeft = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx + 2)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
            ChessPiece? lStandDownLeft = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx - 2)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
            ChessPiece? lStandUpRight = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx + 2)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
            ChessPiece? lStandDownRight = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx - 2)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");

            if (lLieUpLeft != null && lLieUpLeft.Color != this.Color && lLieUpLeft.Name != "Error" || lLieUpLeft == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 2)}");
            }
            if (lLieDownLeft != null && lLieDownLeft.Color != this.Color && lLieDownLeft.Name != "Error" || lLieDownLeft == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 2)}");
            }
            if (lLieUpRight != null && lLieUpRight.Color != this.Color && lLieUpRight.Name != "Error" || lLieUpRight == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 2)}");
            }
            if (lLieDownRight != null && lLieDownRight.Color != this.Color && lLieDownRight.Name != "Error" || lLieDownRight == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 2)}");
            }
            if (lStandUpLeft != null && lStandUpLeft.Color != this.Color && lStandUpLeft.Name != "Error" || lStandUpLeft == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx + 2)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
            }
            if (lStandDownLeft != null && lStandDownLeft.Color != this.Color && lStandDownLeft.Name != "Error" || lStandDownLeft == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx - 2)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
            }
            if (lStandUpRight != null && lStandUpRight.Color != this.Color && lStandUpRight.Name != "Error" || lStandUpRight == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx + 2)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
            }
            if (lStandDownRight != null && lStandDownRight.Color != this.Color && lStandDownRight.Name != "Error" || lStandDownRight == null)
            {
                possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx - 2)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
            }

            // Check if the move is an L shape
            if (possiblePositions.Contains(toPosition.ToUpper()))
            {
                return true;
            }

            return false;
        }

        public override ChessPiece MovePiece(ChessBoard board, string fromPosition, string toPosition)
        {
            ChessPiece pieceFrom = BoardUtils.PositionToPiece(board, fromPosition);

            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));
            int toColIdx = BoardUtils.FileCharToIdx(toPosition[0]);
            int toRowIdx = BoardUtils.RankIntToIdx(int.Parse(toPosition[1].ToString()));

            board.Board[toRowIdx, toColIdx] = pieceFrom;
            board.Board[fromRowIdx, fromColIdx] = null;

            return pieceFrom;
        }
    }
}
