using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class GamePlay
    {
        private readonly Random r_RandomValuePicker;
        private readonly List<GuessesAllowed.eGuessesId> r_ChosenValues;
        private readonly Board r_GameBoard;

        public List<GuessesAllowed.eGuessesId> ChosenValues
        {
            get
            {
                return r_ChosenValues;
            }
        }

        public List<Guess> GameBoard
        {
            get
            {
                return r_GameBoard.GameBoard;
            }
        }

        public GamePlay()
        {
            r_RandomValuePicker = new Random();
            r_ChosenValues = new List<GuessesAllowed.eGuessesId>(4);
            r_GameBoard = new Board();
        }

        public bool checkWinningAndUpdateBoard(List<GuessesAllowed.eGuessesId> i_UserGuesses)
        {
            int lettersInPlace = lettersInRightPlace(i_UserGuesses);
            int lettersExistNotInPlace = lettersNotInRightPlace(i_UserGuesses);

            r_GameBoard.updateRow(i_UserGuesses, lettersInPlace, lettersExistNotInPlace);

            return hasWon(i_UserGuesses);
        }

        public void setNewGame(int i_NewSize)
        {
            r_GameBoard.clearBoardAndResize(i_NewSize);
            setGame();
        }

        private GuessesAllowed.eGuessesId getRandomCharacter(List<GuessesAllowed.eGuessesId> i_AvailableOptions, Random i_RandomGenerator)
        {
            int index = i_RandomGenerator.Next(i_AvailableOptions.Count);

            return i_AvailableOptions[index];
        }

        private void setGame()
        {
            List<GuessesAllowed.eGuessesId> availableOptions = Enum.GetValues(typeof(GuessesAllowed.eGuessesId)).OfType<GuessesAllowed.eGuessesId>().ToList();
            
            r_ChosenValues.Clear();
            for (int i = 0; i < 4; i++)
            {
                r_ChosenValues.Add(getRandomCharacter(availableOptions, r_RandomValuePicker));
                availableOptions.Remove(r_ChosenValues[i]);
            }
        }

        private int lettersNotInRightPlace(List<GuessesAllowed.eGuessesId> i_UserGuesses)
        {
            int rightAttempts = 0;
            int lettersFoundInRightPlace = lettersInRightPlace(i_UserGuesses);

            foreach(GuessesAllowed.eGuessesId letter in i_UserGuesses)
            {
                if(r_ChosenValues.Contains(letter))
                {
                    rightAttempts++;
                }
            }

            return rightAttempts - lettersFoundInRightPlace;
        }

        private int lettersInRightPlace(List<GuessesAllowed.eGuessesId> i_UserGuesses)
        {
            int rightGuesses = 0;

            for(int i = 0; i < 4; i++)
            {
                if(i_UserGuesses[i] == r_ChosenValues[i])
                {
                    rightGuesses++;
                }
            }

            return rightGuesses;
        }

        private bool hasWon(List<GuessesAllowed.eGuessesId> i_UserGuesses)
        {
            return lettersInRightPlace(i_UserGuesses) == 4;
        }
    }
}
