namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_12
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Http;

    public class Program
    {
        public static int Main(string[] args)
        {
            int result;
            string targetFileName;
            string url;

            switch(args.Length)
            {
                default:
                    // Exactly two arguments must be specified; give an error
                    Console.WriteLine(
                        "ERROR:  You must specify the "
                        + "URL and the file name");
                    targetFileName = null;
                    url = null;
                    break;
                case 2:
                    url = args[0];
                    targetFileName = args[1];
                    break;
            }

            if(targetFileName != null && url != null)
            {
                using (HttpClient httpClient = new HttpClient())
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url))
                using (HttpResponseMessage message = httpClient.SendAsync(request).Result)
                using (Stream contentStream = message.Content.ReadAsStreamAsync().Result)
                using (FileStream fileStream = new FileStream(targetFileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    contentStream.CopyToAsync(fileStream);
                }
                result = 0;
            }
            else
            {
                Console.WriteLine(
                    "Usage: Downloader.exe <URL> <TargetFileName>");
                result = 1;
            }

            return result;
        }
    }
}