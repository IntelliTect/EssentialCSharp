namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_16;

#region INCLUDE
public class Program
{
    #region HIGHLIGHT
    public static int Main(string[] args)
    #endregion HIGHLIGHT
    {
        #region HIGHLIGHT
        int result;
        if(args?.Length != 2 )
        #endregion HIGHLIGHT
        {
            // 必须提供两个（而且只能是两个）参数，所以报错
            Console.WriteLine(
                "错误: 必须指定"
                + "URL和文件名");
            Console.WriteLine(
                "用法: Downloader.exe <URL> <文件名>");
            result = 1;
        }
        else
        {
            #region HIGHLIGHT
            string urlString = args[0];
            string fileName = args[1];
            #endregion HIGHLIGHT
            HttpClient client = new();
            byte[] response =
                client.GetByteArrayAsync(urlString).Result;
            client.Dispose();
            File.WriteAllBytes(fileName, response);
            Console.WriteLine($"已从'{urlString}'下载'{fileName}'。");
            result = 0;
        }
        #region HIGHLIGHT
        return result;
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
