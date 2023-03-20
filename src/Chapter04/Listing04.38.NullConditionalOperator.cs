namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_38;

public class Program
{
    public static void Main(params string[] args)
    {
        #region INCLUDE
        string[]? segments = null;
        string? uri = null;

        #region EXCLUDE
        // Not shown in manuscript since args won't be null in a normal Main method.
        segments = args;

        #endregion EXCLUDE

        int? length = segments?.Length;
        #region EXCLUDE
        // Pattern matching also allows:
        // the following but this is not used
        // until covering the topic fully in Chapter 7.
        if (length is not null and not 0) { /*...*/ }
        #endregion EXCLUDE
        if (length is not null && length != 0)
        {
            uri = string.Join('/', segments!);
        }

        if (uri is null || length is 0)
        {
            Console.WriteLine(
                "There were no segments to combine.");
        }
        else
        {
            Console.WriteLine(
                $"Uri: { uri }");
        }
        #endregion INCLUDE
    }
}
