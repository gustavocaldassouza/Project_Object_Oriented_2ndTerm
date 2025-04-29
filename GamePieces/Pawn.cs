using Board;
using Interface;
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
            // extract fromRowIdx and fromColidx from fromPosition
            int fromColIdx = BoardUtils.FileCharToIdx(fromPosition[0]);
            int fromRowIdx = BoardUtils.RankIntToIdx(int.Parse(fromPosition[1].ToString()));
            // extarct toRowIdx and toColidx from toPosition
            int toColIdx = BoardUtils.FileCharToIdx(toPosition[0]);
            int toRowIdx = BoardUtils.RankIntToIdx(int.Parse(toPosition[1].ToString()));
            // generate possible positions for pawn
            // save possible positions in a list
            List<string> possiblePositions = new List<string>();

            if (this.Color == "White")
            {
                // if the pawn is on the second row, it can move two spaces forward
                if (fromRowIdx == 6)
                {
                    if (BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx - 2)}") == null)
                    {
                        possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx - 2)}");
                    }
                }
                if (BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}") == null)
                {
                    possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
                }

                // Move diagonally to capture an opponent's piece
                ChessPiece? rightCapture = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
                ChessPiece? leftCapture = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
                if (rightCapture != null && rightCapture.Color != this.Color)
                {
                    possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
                }
                if (leftCapture != null && leftCapture.Color != this.Color)
                {
                    possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx - 1)}");
                }
            }
            else if (this.Color == "Black")
            {
                // if the pawn is on the seventh row, it can move two spaces forward
                if (fromRowIdx == 1)
                {
                    if (BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx + 2)}") == null)
                    {
                        possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx + 2)}");
                    }
                }
                if (BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}") == null)
                {
                    possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
                }

                // Move diagonally to capture an opponent's piece
                ChessPiece? rightCapture = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
                ChessPiece? leftCapture = BoardUtils.PositionToPiece(board, $"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
                if (rightCapture != null && rightCapture.Color != this.Color)
                {
                    possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx - 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
                }
                if (leftCapture != null && leftCapture.Color != this.Color)
                {
                    possiblePositions.Add($"{BoardUtils.FileIntToChar(fromColIdx + 1)}{BoardUtils.RankIdxToInt(fromRowIdx + 1)}");
                }
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
            // Doesn't make sense accordingly to PDF
            // ChessPiece pieceDest = BoardUtils.PositionToPiece(board, toPosition);
            // if (pieceDest != null)
            // {
            //     return pieceDest;
            // }

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
