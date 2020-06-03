namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_23
{
    public class Program
    {
        public static void Main()
        {
            int[][] cells = {
                new int[] {1, 0, 2},
                new int[] {0, 2, 0},
                new int[] {1, 2, 1}
            };

            cells[1][0] = 1;
            // ...
        }
    }
}
