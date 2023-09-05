namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_33;

public class Program
{
    public static void Main()
    {
        DownloadSSL(null!, null!);
    }

    public static void DownloadSSL(string httpsUrl, string fileName)
    {
#if !NET7_0_OR_GREATER
        httpsUrl = httpsUrl?.Trim() ??
            throw new ArgumentNullException(nameof(httpsUrl));
        fileName = fileName ??
            throw new ArgumentNullException(nameof(fileName));
        if (fileName.Trim().Length == 0)
        {
            throw new ArgumentException(
                $"{nameof(fileName)} cannot be empty or only whitespace");
        }
#else
        #region INCLUDE
        ArgumentNullException.ThrowIfNull(httpsUrl);
        ArgumentNullException.ThrowIfNull(fileName);

        // ...
        #endregion INCLUDE
#endif

    }
}
