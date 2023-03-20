namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_02;

public class Program
{
    #region INCLUDE
    #nullable enable
    public static void Main()
    {
        #if COMPILEERROR // EXCLUDE
        string? text;
        // ...
        // Compile Error: Use of unassigned local variable 'text'
        System.Console.WriteLine(text.Length);
        #endif // COMPILEERROR // EXCLUDE
    }
    #endregion INCLUDE
}
