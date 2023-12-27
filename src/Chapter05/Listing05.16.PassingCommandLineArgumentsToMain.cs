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
            // �����ṩ����������ֻ�������������������Ա���
            Console.WriteLine(
                "����: ����ָ��"
                + "URL���ļ���");
            Console.WriteLine(
                "�÷�: Downloader.exe <URL> <�ļ���>");
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
            Console.WriteLine($"�Ѵ�'{urlString}'����'{fileName}'��");
            result = 0;
        }
        #region HIGHLIGHT
        return result;
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
