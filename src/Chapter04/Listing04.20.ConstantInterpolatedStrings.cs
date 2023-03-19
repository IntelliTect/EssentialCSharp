namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_20;

public class FortyTwo
{
    public static void Main()
    {
        #region INCLUDE
        const string windSpeed = "42";
        const string announcement = $"""
                The original Tacoma Bridge in Washington
                was brought down by a { windSpeed } mile/hour wind.
                """;
        Console.WriteLine(announcement);
        #endregion INCLUDE
    }
}
