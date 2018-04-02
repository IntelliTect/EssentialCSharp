namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_62
{
    public class Program
    {
        public static void Main()
        {
            // ...

            #region Display Tic-tac-toe Board

#if CSHARP2PLUS
            System.Console.Clear();
#endif

            // Display the current board
            border = 0;   //  set the first border (border[0] = "|")

            // Display the top line of dashes
            // ("\n---+---+---\n")
            System.Console.Write(borders[2]);
            foreach(char cell in cells)
            {
                // Write out a cell value and the border that comes after it
                System.Console.Write($" { cell } { borders[border] }");

                // Increment to the next border
                border++;

                // Reset border to 0 if it is 3
                if(border == 3)
                {
                    border = 0;
                }
            }

            #endregion Display Tic-tac-toe Board

            // ...
        }

        public static int border { get; set; }
        public static int[] borders { get; set; }
        public static System.Collections.Generic.IEnumerable<char> cells { get; set; }
    }
}
