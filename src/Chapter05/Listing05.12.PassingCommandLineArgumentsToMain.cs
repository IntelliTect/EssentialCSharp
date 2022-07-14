namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_12
{
    #region INCLUDE
    using System;
    using System.Net;

    public class Program
    {
        #region HIGHLIGHT
        public static int Main(string[] args)
        #endregion HIGHLIGHT
        {
            #region HIGHLIGHT
            int result;
            switch(args.Length)
            #endregion HIGHLIGHT
            {
                default:
                    // Exactly two arguments must be specified; give an error
                    Console.WriteLine(
                        "ERROR:  You must specify the "
                        + "URL and the file name");
                    Console.WriteLine(
                        "Usage: Downloader.exe <URL> <TargetFileName>");
                    result = 1;
                    break;
                case 2:
                    WebClient webClient = new WebClient();
                    #region HIGHLIGHT
                    webClient.DownloadFile(args[0], args[1]);
                    #endregion HIGHLIGHT
                    result = 0;
                    #region HIGHLIGHT
                    break;
                    #endregion HIGHLIGHT
            }
            #region HIGHLIGHT
            return result;
            #endregion HIGHLIGHT
        }
    }
    #endregion INCLUDE
}