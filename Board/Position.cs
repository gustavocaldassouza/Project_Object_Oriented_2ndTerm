namespace Board
{
    public class Position
    {
        public int Rank;
        public char File;

        public Position(int rank, char file)
        {
            if (rank >= 1 && rank <= 8)
            {
                Rank = rank;
            }
            else
            {
                Rank = 1; 
            }

            if (file >= 'A' && file <= 'H')
            {
                File = file;
            }
            else
            {
                File = 'A'; 
            }
        }

        public string Show()
        {
            return File + Rank.ToString();
        }

        public bool IsEqual(Position other)
        {
            return this.Rank == other.Rank && this.File == other.File;
        }
    }
}
