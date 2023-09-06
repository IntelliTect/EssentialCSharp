#pragma warning disable IDE0059 // Unnecessary assignment of a value
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_32;

public class Program
{
    public static void Main()
    {
        DownloadSSL(null!, null!);
    }

    public static void DownloadSSL(string httpsUrl, string fileName)
    {
        #region INCLUDE
        httpsUrl = httpsUrl ??
            throw new ArgumentNullException(nameof(httpsUrl));
        fileName = fileName??
            throw new ArgumentNullException(nameof(fileName));


        // ...
        #endregion INCLUDE
    }
}
