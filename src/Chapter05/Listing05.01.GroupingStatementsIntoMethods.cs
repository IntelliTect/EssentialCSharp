namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_01;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        int lineCount;
        string files;

        DisplayHelpText();
        files = GetFiles();
        lineCount = CountLines(files);
        DisplayLineCount(lineCount);
    }
    
    // ...
    #region EXCLUDE

    private static void DisplayLineCount(int lineCount)
    {
        throw new NotImplementedException();
    }

    private static int CountLines(string files)
    {
        throw new NotImplementedException();
    }

    private static string GetFiles()
    {
        throw new NotImplementedException();
    }

    private static void DisplayHelpText()
    {
        throw new NotImplementedException();
    }
    #endregion EXCLUDE
}
#endregion INCLUDE