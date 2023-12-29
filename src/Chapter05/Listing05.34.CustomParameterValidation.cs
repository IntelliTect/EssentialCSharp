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
            // 必须指定两个（而且只能是两个）参数；报错
            Console.WriteLine(
                "错误: 必须指定"
                + "URL和文件名");
            Console.WriteLine(
                "用法: Downloader.exe <URL> <文件名>");
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
            $"{nameof(fileName)}不能为空或者空串");
    }
#else
    ArgumentException.ThrowIfNullOrEmpty(httpsUrl = httpsUrl?.Trim()!);
    ArgumentException.ThrowIfNullOrEmpty(fileName = fileName?.Trim()!);
#endif

    if (!httpsUrl.ToUpper().StartsWith("HTTPS"))
    {
        throw new ArgumentException("URL必须以'HTTPS'开头。");
    }

    HttpClient client = new();
    byte[] response =
        client.GetByteArrayAsync(httpsUrl).Result;
    client.Dispose();
    File.WriteAllBytes(fileName!, response);
    Console.WriteLine($"已从'{httpsUrl}'下载'{fileName}'。");
}
}
#endregion INCLUDE
