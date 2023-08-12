namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_21;

#region INCLUDE
using System.IO;

public static class LineCounter
{
    // Use the first argument as the directory
    // to search, or default to the current directory
    public static void Main(string[] args)
    {
        int totalLineCount = 0;
        string directory;
        if(args.Length > 0)
        {
            directory = args[0];
        }
        else
        {
            directory = Directory.GetCurrentDirectory();
        }
        totalLineCount = DirectoryCountLines(directory);
        Console.WriteLine(totalLineCount);
    }

    #region HIGHLIGHT
    static int DirectoryCountLines(string directory)
    #endregion HIGHLIGHT
    {
        int lineCount = 0;
        foreach(string file in
            Directory.GetFiles(directory, "*.cs"))
        {
            lineCount += CountLines(file);
        }

        foreach(string subdirectory in
            Directory.GetDirectories(directory))
        {
            #region HIGHLIGHT
            lineCount += DirectoryCountLines(subdirectory);
            #endregion HIGHLIGHT
        }

        return lineCount;
    }

    private static int CountLines(string file)
    {
        string? line;
        int lineCount = 0;
        // This can be improved with a using statement
        // which is not yet described.
        FileStream stream =
            new(file, FileMode.Open);
        StreamReader reader = new(stream);
        line = reader.ReadLine();

        while(line != null)
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
