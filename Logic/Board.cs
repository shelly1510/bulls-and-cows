using System.Collections.Generic;

namespace Logic
{
    public class Board
    {
        private readonly List<Guess> r_GameBoard;

        public Board()
        {
            r_GameBoard = new List<Guess>();
        }

        public List<Guess> GameBoard
        {
            get
            {
                return r_GameBoard;
            }
        }

        public void updateRow(List<GuessesAllowed.eGuessesId> i_UserInput, int i_Successes, int i_Tries)
        {
            r_GameBoard.Add(new Guess(i_UserInput, i_Tries, i_Successes));
        }

        public void clearBoardAndResize(int i_NewSize)
        {
            r_GameBoard.Clear();
            r_GameBoard.Capacity = i_NewSize;
        }
    }
}
