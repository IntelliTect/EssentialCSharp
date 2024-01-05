namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_08;

#region INCLUDE
public sealed class CommandLineParser
{
    // ...
}

#if COMPILEERROR // EXCLUDE
// 错误: 无法从密封类型派生
public sealed class DerivedCommandLineParser
    : CommandLineParser
{
    // ...
}
#endif // COMPILEERROR // EXCLUDE
#endregion INCLUDE
