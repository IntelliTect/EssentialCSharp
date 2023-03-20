namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_17;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        bool[, ,] cells;
        cells = new bool[2, 3, 3]
        {
            // Player 1 moves
            //  X |   |
            // ---+---+---
            //  X |   | 
            // ---+---+---
            //  X |   | X 
            {
                {true, false, false},
                {true, false, false},
                {true, false, true}
            },
            // Player 2 moves
            //    |   | O
            // ---+---+---
            //    | O | 
            // ---+---+---
            //    | O | 
            {
                {false, false, true},
                {false, true, false},
                {false, true, true}
            }
        };
        #endregion INCLUDE
    }
}
