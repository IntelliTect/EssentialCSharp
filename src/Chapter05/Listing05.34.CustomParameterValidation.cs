namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_34;

#region INCLUDE
public class Program
{
    #region HIGHLIGHT
    public static int Main(string[] args)
    #endregion HIGHLIGHT
    {
        #region HIGHLIGHT
        int result = 0;
        #endregion HIGHLIGHT
        if(args.Length != 2 ) 
        { 
            // Exactly two arguments must be specified; give an error
            Console.WriteLine(
                "ERROR:  You must specify the "
                + "URL and the file name");
            Console.WriteLine(
                "Usage: Downloader.exe <URL> <TargetFileName>");
            result = 1;
        }
        else
        {
            DownloadSSL(args[0], args[1]);
        }
        return result;
    }

private static void DownloadSSL(string httpsUrl, string fileName)
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
    ArgumentException.ThrowIfNullOrEmpty(httpsUrl = httpsUrl?.Trim()!);
    ArgumentException.ThrowIfNullOrEmpty(fileName = fileName?.Trim()!);
#endif

    if (!httpsUrl.ToUpper().StartsWith("HTTPS"))
    {
        throw new ArgumentException("URL must start with 'HTTPS'.");
    }

    HttpClient client = new();
    byte[] response =
        client.GetByteArrayAsync(httpsUrl).Result;
    client.Dispose();
    File.WriteAllBytes(fileName!, response);
    Console.WriteLine($"Downloaded '{fileName}' from '{httpsUrl}'.");
}
}
#endregion INCLUDE
