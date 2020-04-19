namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_12
{
    using System;
    using System.Net;

    public class Program
    {
        public static int Main(string[] args)
        {
            int result;

            switch(args.Length)
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
                    webClient.DownloadFile(args[0], args[1]);
                    result = 0;
                    break;
            }

            return result;
        }
    }
}