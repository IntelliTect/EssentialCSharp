namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_08
{
    #region INCLUDE
    public sealed class CommandLineParser
    {
        // ...
    }
    // ERROR:  Sealed classes cannot be derived from
    public sealed class DerivedCommandLineParser
    //: CommandLineParser
    {
        // ...
    }
    #endregion INCLUDE
}
