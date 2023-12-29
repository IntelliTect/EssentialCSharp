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
            // ����ָ������������ֻ��������������������
            Console.WriteLine(
                "����: ����ָ��"
                + "URL���ļ���");
            Console.WriteLine(
                "�÷�: Downloader.exe <URL> <�ļ���>");
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
            $"{nameof(fileName)}����Ϊ�ջ��߿մ�");
    }
#else
    ArgumentException.ThrowIfNullOrEmpty(httpsUrl = httpsUrl?.Trim()!);
    ArgumentException.ThrowIfNullOrEmpty(fileName = fileName?.Trim()!);
#endif

    if (!httpsUrl.ToUpper().StartsWith("HTTPS"))
    {
        throw new ArgumentException("URL������'HTTPS'��ͷ��");
    }

    HttpClient client = new();
    byte[] response =
        client.GetByteArrayAsync(httpsUrl).Result;
    client.Dispose();
    File.WriteAllBytes(fileName!, response);
    Console.WriteLine($"�Ѵ�'{httpsUrl}'����'{fileName}'��");
}
}
#endregion INCLUDE
