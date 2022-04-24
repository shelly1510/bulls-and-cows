using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class MainGameBoard : Form
    {
        private readonly int r_NumberOfTurns;
        private readonly GamePlay r_GamePlay = new GamePlay();
        private readonly List<Button> r_ButtonsOfUserGuesses = new List<Button>();
        private readonly List<Button> r_ButtonsSubmit = new List<Button>();
        private readonly List<Button> r_ButtonsHitOrMiss = new List<Button>();
        private readonly ColorPallet r_ColorPallet = new ColorPallet();
        private readonly List<Color> r_CurrentUserGuessSet = new List<Color>(4);
        private int m_CurrentTurnNumber;

        public MainGameBoard(int i_NumberOfTurns)
        {
                r_NumberOfTurns = i_NumberOfTurns;
                InitializeComponent();
                r_ButtonsOfUserGuesses.Add(buttonGuess1);
                r_ButtonsOfUserGuesses.Add(buttonGuess2);
                r_ButtonsOfUserGuesses.Add(buttonGuess3);
                r_ButtonsOfUserGuesses.Add(buttonGuess4);
                r_ButtonsSubmit.Add(buttonSubmit);
                r_ButtonsHitOrMiss.Add(buttonHitOrMiss1);
                r_ButtonsHitOrMiss.Add(buttonHitOrMiss2);
                r_ButtonsHitOrMiss.Add(buttonHitOrMiss3);
                r_ButtonsHitOrMiss.Add(buttonHitOrMiss4);
                initializeGame();
        }

        private void initializeGame()
        {
            r_GamePlay.setNewGame(r_NumberOfTurns);
            setGuessButtons();
            setSubmitButtons();
            setHitOrMissButtons();
        }

        private void setGuessButtons()
        {
            for (int i = 0; i < r_NumberOfTurns - 1; i++)
            {
                Button button1 = new Button();
                button1.Left = r_ButtonsOfUserGuesses[i * 4].Left;
                button1.Top = r_ButtonsOfUserGuesses[i * 4].Bottom + 12;
                button1.Size = r_ButtonsOfUserGuesses[i * 4].Size;
                button1.Click += buttonGuess_Click;
                button1.Enabled = false;

                Button button2 = new Button();
                button2.Left = r_ButtonsOfUserGuesses[(i * 4) + 1].Left;
                button2.Top = r_ButtonsOfUserGuesses[(i * 4) + 1].Bottom + 12;
                button2.Size = r_ButtonsOfUserGuesses[(i * 4) + 1].Size;
                button2.Click += buttonGuess_Click;
                button2.Enabled = false;

                Button button3 = new Button();
                button3.Left = r_ButtonsOfUserGuesses[(i * 4) + 2].Left;
                button3.Top = r_ButtonsOfUserGuesses[(i * 4) + 2].Bottom + 12;
                button3.Size = r_ButtonsOfUserGuesses[(i * 4) + 2].Size;
                button3.Click += buttonGuess_Click;
                button3.Enabled = false;

                Button button4 = new Button();
                button4.Left = r_ButtonsOfUserGuesses[(i * 4) + 3].Left;
                button4.Top = r_ButtonsOfUserGuesses[(i * 4) + 3].Bottom + 12;
                button4.Size = r_ButtonsOfUserGuesses[(i * 4) + 3].Size;
                button4.Click += buttonGuess_Click;
                button4.Enabled = false;

                r_ButtonsOfUserGuesses.Add(button1);
                r_ButtonsOfUserGuesses.Add(button2);
                r_ButtonsOfUserGuesses.Add(button3);
                r_ButtonsOfUserGuesses.Add(button4);
                this.Controls.Add(button1);
                this.Controls.Add(button2);
                this.Controls.Add(button3);
                this.Controls.Add(button4);
            }
        }

        private void setSubmitButtons()
        {
            for (int i = 0; i < r_NumberOfTurns - 1; i++)
            {
                Button dynButtonSubmit = new Button();
                dynButtonSubmit.Size = r_ButtonsSubmit[i].Size;
                dynButtonSubmit.Left = r_ButtonsSubmit[i].Left;
                dynButtonSubmit.Top = r_ButtonsOfUserGuesses[(i + 1) * 4].Bottom - (r_ButtonsOfUserGuesses[i * 4].Height / 2) - (r_ButtonsSubmit[i].Height / 2);
                dynButtonSubmit.Click += buttonSubmit_Click;
                dynButtonSubmit.Enabled = false;
                dynButtonSubmit.Text = r_ButtonsSubmit[i].Text;
                r_ButtonsSubmit.Add(dynButtonSubmit);
                this.Controls.Add(dynButtonSubmit);
            }
        }

        private void setHitOrMissButtons()
        {
            int heightSpacing = buttonHitOrMiss3.Top - buttonHitOrMiss1.Bottom;

            for (int i = 0; i < r_NumberOfTurns - 1; i++)
            {
                Button dynButtonHitOrMiss1 = new Button();
                dynButtonHitOrMiss1.Size = r_ButtonsHitOrMiss[i * 4].Size;
                dynButtonHitOrMiss1.Left = r_ButtonsHitOrMiss[i * 4].Left;
                dynButtonHitOrMiss1.Top = r_ButtonsOfUserGuesses[(i + 1) * 4].Bottom - (2 * dynButtonHitOrMiss1.Height) - heightSpacing;
                dynButtonHitOrMiss1.Enabled = false;

                Button dynButtonHitOrMiss2 = new Button();
                dynButtonHitOrMiss2.Size = r_ButtonsHitOrMiss[(i * 4) + 1].Size;
                dynButtonHitOrMiss2.Left = r_ButtonsHitOrMiss[(i * 4) + 1].Left;
                dynButtonHitOrMiss2.Top = r_ButtonsOfUserGuesses[(i + 1) * 4].Bottom - (2 * dynButtonHitOrMiss2.Height) - heightSpacing;
                dynButtonHitOrMiss2.Enabled = false;

                Button dynButtonHitOrMiss3 = new Button();
                dynButtonHitOrMiss3.Size = r_ButtonsHitOrMiss[(i * 4) + 2].Size;
                dynButtonHitOrMiss3.Left = r_ButtonsHitOrMiss[(i * 4) + 2].Left;
                dynButtonHitOrMiss3.Top = r_ButtonsOfUserGuesses[(i + 1) * 4].Bottom - dynButtonHitOrMiss3.Height;
                dynButtonHitOrMiss3.Enabled = false;

                Button dynButtonHitOrMiss4 = new Button();
                dynButtonHitOrMiss4.Size = r_ButtonsHitOrMiss[(i * 4) + 3].Size;
                dynButtonHitOrMiss4.Left = r_ButtonsHitOrMiss[(i * 4) + 3].Left;
                dynButtonHitOrMiss4.Top = r_ButtonsOfUserGuesses[(i + 1) * 4].Bottom - dynButtonHitOrMiss4.Height;
                dynButtonHitOrMiss4.Enabled = false;

                r_ButtonsHitOrMiss.Add(dynButtonHitOrMiss1);
                r_ButtonsHitOrMiss.Add(dynButtonHitOrMiss2);
                r_ButtonsHitOrMiss.Add(dynButtonHitOrMiss3);
                r_ButtonsHitOrMiss.Add(dynButtonHitOrMiss4);
                this.Controls.Add(dynButtonHitOrMiss1);
                this.Controls.Add(dynButtonHitOrMiss2);
                this.Controls.Add(dynButtonHitOrMiss3);
                this.Controls.Add(dynButtonHitOrMiss4);
            }
        }

        private void updateColorButton(Button i_Button)
        {
            r_ColorPallet.ShowDialog();

            Color? color = r_ColorPallet.GetColor;

            if (color == null)
            {
                return;
            }

            Color desiredColor = (Color)color;

            r_CurrentUserGuessSet.Remove(i_Button.BackColor);

            for (int i = m_CurrentTurnNumber * 4; i < (m_CurrentTurnNumber + 1) * 4; i++)
            {
                if (r_ButtonsOfUserGuesses[i].BackColor == desiredColor)
                {
                    r_ButtonsOfUserGuesses[i].BackColor = default;
                }
            }
                
            i_Button.BackColor = desiredColor;
            if (!r_CurrentUserGuessSet.Contains(desiredColor))
            {
                r_CurrentUserGuessSet.Add(desiredColor);
            }
        }

        private void changeButtonColor(Button i_ButtonToChange, GuessesAllowed.eGuessesId? i_DesiredColor)
        {
            switch (i_DesiredColor)
            {
                case GuessesAllowed.eGuessesId.Pink:
                    i_ButtonToChange.BackColor = Color.MediumVioletRed;
                    break;
                case GuessesAllowed.eGuessesId.Red:
                    i_ButtonToChange.BackColor = Color.Red;
                    break;
                case GuessesAllowed.eGuessesId.Green:
                    i_ButtonToChange.BackColor = Color.LawnGreen;
                    break;
                case GuessesAllowed.eGuessesId.Cyan:
                    i_ButtonToChange.BackColor = Color.Cyan;
                    break;
                case GuessesAllowed.eGuessesId.Blue:
                    i_ButtonToChange.BackColor = Color.Blue;
                    break;
                case GuessesAllowed.eGuessesId.Yellow:
                    i_ButtonToChange.BackColor = Color.Yellow;
                    break;
                case GuessesAllowed.eGuessesId.Brown:
                    i_ButtonToChange.BackColor = Color.SaddleBrown;
                    break;
                case GuessesAllowed.eGuessesId.White:
                    i_ButtonToChange.BackColor = Color.White;
                    break;
                default:
                    i_ButtonToChange.BackColor = default(Color);
                    break;
            }
        }

        private void updateHitOrMiss()
        {
            Guess currentTurnData = r_GamePlay.GameBoard[m_CurrentTurnNumber];
            int hitOrMissIndex = m_CurrentTurnNumber * 4;

            for (int i = 0; i < currentTurnData.NumOfRightPositionLetters; i++)
            {
                r_ButtonsHitOrMiss[hitOrMissIndex++].BackColor = Color.Black;
            }

            for (int i = 0; i < currentTurnData.NumOfIncorrectPositionLetters; i++)
            {
                r_ButtonsHitOrMiss[hitOrMissIndex++].BackColor = Color.Yellow;
            }
        }

        private void revealAnswer()
        {
            GuessesAllowed.eGuessesId answerColor1 = r_GamePlay.ChosenValues[0];
            GuessesAllowed.eGuessesId answerColor2 = r_GamePlay.ChosenValues[1];
            GuessesAllowed.eGuessesId answerColor3 = r_GamePlay.ChosenValues[2];
            GuessesAllowed.eGuessesId answerColor4 = r_GamePlay.ChosenValues[3];

            changeButtonColor(buttonGameGuessFirst, answerColor1);
            changeButtonColor(buttonGameGuessSecond, answerColor2);
            changeButtonColor(buttonGameGuessThird, answerColor3);
            changeButtonColor(buttonGameGuessFourth, answerColor4);
        }

        private void openNextRowDisableCurrent(bool i_HasWon)
        {
            int userGuessIndex = (m_CurrentTurnNumber - 1) * 4;

            for (int i = 0; i < 4; i++)
            {
                r_ButtonsOfUserGuesses[userGuessIndex + i].Enabled = false;
            }

            r_ButtonsSubmit[m_CurrentTurnNumber - 1].Enabled = false;

            if(!i_HasWon && m_CurrentTurnNumber != r_NumberOfTurns)
            {
                userGuessIndex = m_CurrentTurnNumber * 4;
                for (int i = 0; i < 4; i++)
                {
                    r_ButtonsOfUserGuesses[userGuessIndex + i].Enabled = true;
                }
            }
        }

        private void toggleSubmitButtonIfNeeded()
        {
            r_ButtonsSubmit[m_CurrentTurnNumber].Enabled = r_CurrentUserGuessSet.Count == 4;
        }

        private bool isRowFull()
        {
            bool isFull = r_CurrentUserGuessSet.Count == 4;

            return isFull;
        }

        private void buttonGuess_Click(object i_Sender, EventArgs i_EventArgs)
        {
            Button button = i_Sender as Button;

            updateColorButton(button);
            toggleSubmitButtonIfNeeded();
        }

        private void buttonSubmit_Click(object i_Sender, EventArgs i_EventArgs)
        {
            if(!isRowFull())
            {
                return;
            }

            List<GuessesAllowed.eGuessesId> colorsSendToLogic = new List<GuessesAllowed.eGuessesId>();

            for (int i = m_CurrentTurnNumber * 4; i < (m_CurrentTurnNumber + 1) * 4; i++)
            {
                colorsSendToLogic.Add(colorConvertToeGuessId(r_ButtonsOfUserGuesses[i].BackColor));
            }

            r_CurrentUserGuessSet.Clear();

            bool hasWon = r_GamePlay.checkWinningAndUpdateBoard(colorsSendToLogic);

            updateHitOrMiss();
            m_CurrentTurnNumber++;
            openNextRowDisableCurrent(hasWon);
            if (hasWon || r_NumberOfTurns == m_CurrentTurnNumber)
            {
                revealAnswer();
            }
        }

        private GuessesAllowed.eGuessesId colorConvertToeGuessId(Color i_Color)
        {
            GuessesAllowed.eGuessesId toReturn = GuessesAllowed.eGuessesId.Blue;

            switch (i_Color.Name)
            {
                case "MediumVioletRed":
                    toReturn = GuessesAllowed.eGuessesId.Pink; 
                    break;
                case "Red":
                    toReturn = GuessesAllowed.eGuessesId.Red;
                    break;
                case "LawnGreen":
                    toReturn = GuessesAllowed.eGuessesId.Green;
                    break;
                case "Cyan":
                    toReturn = GuessesAllowed.eGuessesId.Cyan;
                    break;
                case "Blue":
                    toReturn = GuessesAllowed.eGuessesId.Blue;
                    break;
                case "Yellow":
                    toReturn = GuessesAllowed.eGuessesId.Yellow;
                    break;
                case "SaddleBrown":
                    toReturn = GuessesAllowed.eGuessesId.Brown;
                    break;
                case "White":
                    toReturn = GuessesAllowed.eGuessesId.White;
                    break;
                default:
                    break;
            }

            return toReturn;
        }
    }
}
