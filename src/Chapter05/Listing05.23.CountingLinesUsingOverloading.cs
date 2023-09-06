namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_23;

#region INCLUDE
public static class LineCounter
{
    public static void Main(string[] args)
    {
        int totalLineCount;

        if(args.Length > 1)
        {
            #region HIGHLIGHT
            totalLineCount = DirectoryCountLines(args[0], args[1]);
            #endregion HIGHLIGHT
        }
        else if(args.Length > 0)
        {
            #region HIGHLIGHT
            totalLineCount = DirectoryCountLines(args[0]);
            #endregion HIGHLIGHT
        }
        else
        {
            #region HIGHLIGHT
            totalLineCount = DirectoryCountLines();
            #endregion HIGHLIGHT
        }

        Console.WriteLine(totalLineCount);
    }

    #region HIGHLIGHT
    static int DirectoryCountLines()
    #endregion HIGHLIGHT
    {
        return DirectoryCountLines(
            Directory.GetCurrentDirectory());
    }

    #region HIGHLIGHT
    static int DirectoryCountLines(string directory)
    #endregion HIGHLIGHT
    {
        return DirectoryCountLines(directory, "*.cs");
    }

    #region HIGHLIGHT
    static int DirectoryCountLines(
    #endregion HIGHLIGHT
        string directory, string extension)
    {
        int lineCount = 0;
        foreach(string file in
            Directory.GetFiles(directory, extension))
        {
            lineCount += CountLines(file);
        }

        foreach(string subdirectory in
            Directory.GetDirectories(directory))
        {
            lineCount += DirectoryCountLines(subdirectory);
        }

        return lineCount;
    }

    private static int CountLines(string file)
    {
        int lineCount = 0;
        string? line;
        // This can be improved with a using statement
        // which is not yet described.
        FileStream stream = new(file, FileMode.Open);
        StreamReader reader = new(stream);
        line = reader.ReadLine();
        while(line is not null)
        {
            if(line.Trim() != "")
            {
                lineCount++;
            }
            line = reader.ReadLine();
        }

        reader.Dispose();  // Automatically closes the stream
        return lineCount;
    }
}
#endregion INCLUDE
