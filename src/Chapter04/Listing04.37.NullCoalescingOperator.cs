namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_37;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string? fullName = GetSaveFilePath();
        // ...

        // Null-coalescing operator
        string fileName = GetFileName() ?? "config.json";
        string directory = GetConfigurationDirectory() ??
            GetApplicationDirectory() ??
            Environment.CurrentDirectory;

        // Null-coalescing assignment operator
        fullName ??= $"{ directory }/{ fileName }";

        // ...
        #endregion INCLUDE

    }

    private static string? GetSaveFilePath()
    {
        throw new NotImplementedException();
    }

    private static string? GetApplicationDirectory()
    {
        throw new NotImplementedException();
    }

    private static string? GetConfigurationDirectory()
    {
        throw new NotImplementedException();
    }

    private static string? GetFileName()
    {
        throw new System.NotImplementedException();
    }
}
