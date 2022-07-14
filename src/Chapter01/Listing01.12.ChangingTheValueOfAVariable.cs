namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_12
{
    #region INCLUDE
    public class StormingTheCastle
    {
        public static void Main()
        {
            string valerie;
            #region HIGHLIGHT
            string miracleMax = "Have fun storming the castle!";

            valerie = "Think it will work?";
            #endregion HIGHLIGHT

            System.Console.WriteLine(miracleMax);
            System.Console.WriteLine(valerie);

            #region HIGHLIGHT
            miracleMax = "It would take a miracle.";
            #endregion HIGHLIGHT
            System.Console.WriteLine(miracleMax);
        }
    }
    #endregion INCLUDE
}
