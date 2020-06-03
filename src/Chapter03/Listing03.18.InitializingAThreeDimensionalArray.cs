namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_18
{
    public class Program
    {
        public static void Main()
        {
            bool[, ,] cells;
            cells = new bool[2, 3, 3] 
            {
                // Player 1 moves 
                {                          //  X |   |
                    {true, false, false},  // ---+---+---
                    {true, false, false},  //  X |   | 
                    {true, false, true}    // ---+---+---
                },                         //  X |   | X 
                // Player 2 moves 
                {                          //    |   | O
                    {false, false, true},  // ---+---+---
                    {false, true, false},  //    | O | 
                    {false, true, true}    // ---+---+---
                }                          //    | O | 
            };
        }
    }
}
