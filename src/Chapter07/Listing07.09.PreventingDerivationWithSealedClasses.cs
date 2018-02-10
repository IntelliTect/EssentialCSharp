namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_09
{
    public sealed class CommandLineParser
    {
        // ...
    }
    // ERROR:  Sealed classes cannot be derived from
    public sealed class DerivedCommandLineParser
    //: CommandLineParser //uncomment this line and it will not compile
    {
        // ...
    }
}
