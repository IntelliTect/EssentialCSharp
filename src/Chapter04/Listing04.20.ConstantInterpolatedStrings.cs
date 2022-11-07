#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_20
{
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
}
