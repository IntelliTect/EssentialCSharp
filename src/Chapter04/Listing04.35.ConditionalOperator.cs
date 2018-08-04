namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_35
{
    public class TicTacToe
    {
        public static void Main()
        {
            // Initially set the currentPlayer to Player 1
            int currentPlayer = 1;

            // ...

            for(int turn = 1; turn <= 10; turn++)
            {
                // ...

                // Switch players
                currentPlayer = (currentPlayer == 2) ? 1 : 2;
            }
        }
    }

}
