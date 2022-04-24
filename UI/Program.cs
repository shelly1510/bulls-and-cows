namespace UI
{
    public class Program
    {
       public static void Main()
        {
            TurnsForm turns = new TurnsForm();
            turns.ShowDialog();
            if (turns.ClosedByStart)
            {
                // pass turns.NumberChosen as param if using turns form here, else pass no params
            MainGameBoard mainGameBoard = new MainGameBoard(turns.NumberChosen); 
            mainGameBoard.ShowDialog();
            }
        }
    }
}
