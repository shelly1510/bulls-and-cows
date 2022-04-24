using System.Collections.Generic;

namespace Logic
{
    public struct Guess
    {
        private readonly List<GuessesAllowed.eGuessesId> r_Guess;
        private readonly int r_NumOfIncorrectPositionLetters;
        private readonly int r_NumOfRightPositionLetters;

        public Guess(List<GuessesAllowed.eGuessesId> i_Guess, int i_NumOfIncorrectPositionLetters, int i_NumOfRightPositionLetters)
        {
            r_Guess = new List<GuessesAllowed.eGuessesId>();
            
            r_Guess.AddRange(i_Guess);
            r_NumOfIncorrectPositionLetters = i_NumOfIncorrectPositionLetters;
            r_NumOfRightPositionLetters = i_NumOfRightPositionLetters;
        }

        public List<GuessesAllowed.eGuessesId> GuessPins
        { 
            get
            {
                return r_Guess;
            }
        }

        public int NumOfIncorrectPositionLetters
        {
            get
            {
                return r_NumOfIncorrectPositionLetters;
            }
        }

        public int NumOfRightPositionLetters
        { 
            get
            {
                return r_NumOfRightPositionLetters;
            }
        }
    } 
}
